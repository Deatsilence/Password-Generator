using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrongPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Assign password length to comboBox by difficulty
        //
        private static void AddComboBox(ref ComboBox cbox, int min, int max)
        {
            for (int i = min; i <= max; i++)
                cbox.Items.Add(i);
        }
        //
        // Nitially easy radioButton is selected and every radioButton makes a button
        //
        private static void GroupBoxControl(ref GroupBox gbox)
        {
            RadioButton rbtn = (RadioButton)gbox.Controls[0];
            rbtn.Checked = true;

            foreach (RadioButton item in gbox.Controls)
                item.Appearance = Appearance.Button;
        }
        //
        // Control radioButton
        //
        private static string RadioButtonControl(ref GroupBox gbox)
        {
            foreach (RadioButton item in gbox.Controls)
            {
                if (item.Checked)
                    return item.Name;
            }
            return string.Empty;
        }
        //
        // List of special characters, numbers, upper and lower case letters
        //
        private static List<char> Allascii = new List<char>(93);
        //
        // Numbers, upper and lower case letters list
        //
        private static List<char> notSpecialch = new List<char>(62);
        //
        // Importing characters to lists
        //
        private static void AddASCII()
        {
            for (int i = 33; i <= 125; i++)
                Allascii.Add(Convert.ToChar(i));

            for (int j = 48; j <= 122; j++)
            {
                if (char.IsLetterOrDigit(Convert.ToChar(j)))
                    notSpecialch.Add(Convert.ToChar(j));
            }
        }
        //
        // Measures password security
        //
        private static int SecurityRating(ref char[] _password, ref ProgressBar progressBar)
        {
            int SumResult = 0;
            for (int i = 0; i < _password.Length; i++)
            {
                if (char.IsUpper(_password[i]))
                    SumResult += 2;

                else if (char.IsLower(_password[i]))
                    SumResult += 2;

                else if (char.IsDigit(_password[i]))
                    SumResult += 3;

                else if (char.IsPunctuation(_password[i]))
                    SumResult += 4;

                else if (char.IsSymbol(_password[i]))
                    SumResult += 6;

            }
            return SumResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.BackColor = Color.DarkGray;
            this.lblPasswordLength.BackColor = Color.DarkGray;
            this.lblPasswordSecurity.BackColor = Color.DarkGray;
            this.lblCreatedPassword.BackColor = Color.DarkGray;
            this.groupBox1.BackColor = Color.DarkGray;
            this.rbtnEasy.BackColor = Color.DarkRed;
            this.rbtnMiddle.BackColor = Color.YellowGreen;
            this.rbtnHard.BackColor = Color.DarkGreen;
            //
            // AddASCII Method
            //
            AddASCII();
            //
            // btnMake
            //
            btnMake.Enabled = false;
            btnMake.BackColor = Color.DarkOrange;
            //
            // groupBox1Controls
            //
            GroupBoxControl(ref groupBox1);
            //
            // CboxLenght
            //
            if (RadioButtonControl(ref groupBox1) == rbtnEasy.Name)
                AddComboBox(ref cboxLenght, 4, 8);
            else if (RadioButtonControl(ref groupBox1) == rbtnMiddle.Name)
                AddComboBox(ref cboxLenght, 4, 16);
            else if (RadioButtonControl(ref groupBox1) == rbtnHard.Name)
                AddComboBox(ref cboxLenght, 8, 32);
            cboxLenght.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // ProgessBar1
            //
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Enabled = false;
            //
            // toolTip
            //
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(this.lblPercent, "No password is 100% secure!");
            toolTip1.SetToolTip(this.rbtnEasy, "4-8 character long password consisting of only uppercase and lowercase letters, and numbers repeated by characters.");
            toolTip1.SetToolTip(this.rbtnMiddle, "4-16 character long password consisting of only upper and lower case letters, punctuation marks, symbols and numbers repeated by characters");
            toolTip1.SetToolTip(this.rbtnMiddle, "12-32 character long password consisting of only uppercase and lowercase letters, punctuation marks, symbols and numbers without repeating characters.");
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            // password list of selected length
            int capacity = Convert.ToInt32(cboxLenght.SelectedItem);
            List<char> password = new List<char>(capacity);

            // access to random index
            Random rnd = new Random();
            string result = string.Empty;

            // if easy password is selected
            if (RadioButtonControl(ref groupBox1) == rbtnEasy.Name)
            {
                for (int i = 0; i < capacity; i++)
                {
                    // random password generation
                    int x = rnd.Next(0, notSpecialch.Count);
                    password.Add(notSpecialch[x]);
                }
                result = new string(password.ToArray());
                lblPassword.Text = result;

                char[] temp = result.ToCharArray();

                progressBar1.Value += (capacity + SecurityRating(ref temp, ref progressBar1));

                lblPercent.Text = "% " + progressBar1.Value.ToString();
            }
            //
            // if middle password is selected
            //
            else if (RadioButtonControl(ref groupBox1) == rbtnMiddle.Name)
            {
                for (int i = 0; i < capacity; i++)
                {
                    // random password generation
                    int x = rnd.Next(0, Allascii.Count);
                    password.Add(Allascii[x]);
                }
                result = new string(password.ToArray());
                lblPassword.Text = result;

                char[] temp = result.ToCharArray();
                SecurityRating(ref temp, ref progressBar1);

                int control = (capacity + SecurityRating(ref temp, ref progressBar1));

                if (control >= 100)
                    progressBar1.Value = 100;
                else
                    progressBar1.Value += control;

                if (capacity > 12 && (progressBar1.Value + (capacity * 2)) < 100)
                    progressBar1.Value += (capacity * 2);

                lblPercent.Text = "% " + progressBar1.Value.ToString();
            }
            //
            // if hard password is selected
            //
            else if (RadioButtonControl(ref groupBox1) == rbtnHard.Name)
            {
                for (int i = 0; i < capacity;)
                {
                    // random password generation
                    int x = rnd.Next(0, Allascii.Count);
                    // so that the character does not repeat
                    if (!password.Contains(Allascii[x]))
                    {
                        password.Add(Allascii[x]);
                        i++;
                    }
                }
                result = new string(password.ToArray());
                lblPassword.Text = result;

                char[] temp = result.ToCharArray();
                SecurityRating(ref temp, ref progressBar1);

                int control = (capacity + SecurityRating(ref temp, ref progressBar1));

                if (control >= 100)
                    progressBar1.Value = 100;
                else
                    progressBar1.Value += control;

                if (capacity > 16 && (progressBar1.Value + (capacity * 2)) < 100)
                    progressBar1.Value += (capacity * 2);

                lblPercent.Text = "% " + progressBar1.Value.ToString();
            }
            if (lblPassword.Text != string.Empty)
                Clipboard.SetText(lblPassword.Text);
        }

        private void CammonRadioButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonControl(ref groupBox1) == rbtnEasy.Name)
            {
                cboxLenght.Items.Clear();
                AddComboBox(ref cboxLenght, 4, 8);
            }
            else if (RadioButtonControl(ref groupBox1) == rbtnMiddle.Name)
            {
                cboxLenght.Items.Clear();
                AddComboBox(ref cboxLenght, 4, 16);
            }

            else if (RadioButtonControl(ref groupBox1) == rbtnHard.Name)
            {
                cboxLenght.Items.Clear();
                AddComboBox(ref cboxLenght, 12, 32);
            }
            if (cboxLenght.SelectedIndex > -1)
                btnMake.Enabled = true;
            else
                btnMake.Enabled = false;
        }

        private void cboxLenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLenght.SelectedIndex > -1)
                btnMake.Enabled = true;
            else
                btnMake.Enabled = false;
        }
    }
}
