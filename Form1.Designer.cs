
namespace CrongPassword
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboxLenght = new System.Windows.Forms.ComboBox();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.rbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPasswordSecurity = new System.Windows.Forms.Label();
            this.btnMake = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCreatedPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxLenght
            // 
            this.cboxLenght.BackColor = System.Drawing.Color.White;
            this.cboxLenght.FormattingEnabled = true;
            this.cboxLenght.Location = new System.Drawing.Point(160, 15);
            this.cboxLenght.Name = "cboxLenght";
            this.cboxLenght.Size = new System.Drawing.Size(50, 26);
            this.cboxLenght.TabIndex = 0;
            this.cboxLenght.SelectedIndexChanged += new System.EventHandler(this.cboxLenght_SelectedIndexChanged);
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.BackColor = System.Drawing.Color.White;
            this.lblPasswordLength.Location = new System.Drawing.Point(12, 15);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(143, 18);
            this.lblPasswordLength.TabIndex = 1;
            this.lblPasswordLength.Text = "Password Length:";
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.BackColor = System.Drawing.Color.White;
            this.rbtnEasy.Location = new System.Drawing.Point(6, 23);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(63, 22);
            this.rbtnEasy.TabIndex = 2;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = false;
            this.rbtnEasy.Click += new System.EventHandler(this.CammonRadioButton_Click);
            // 
            // rbtnMiddle
            // 
            this.rbtnMiddle.AutoSize = true;
            this.rbtnMiddle.BackColor = System.Drawing.Color.White;
            this.rbtnMiddle.Location = new System.Drawing.Point(102, 23);
            this.rbtnMiddle.Name = "rbtnMiddle";
            this.rbtnMiddle.Size = new System.Drawing.Size(75, 22);
            this.rbtnMiddle.TabIndex = 3;
            this.rbtnMiddle.TabStop = true;
            this.rbtnMiddle.Text = "Middle";
            this.rbtnMiddle.UseVisualStyleBackColor = false;
            this.rbtnMiddle.Click += new System.EventHandler(this.CammonRadioButton_Click);
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.BackColor = System.Drawing.Color.White;
            this.rbtnHard.Location = new System.Drawing.Point(189, 23);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(62, 22);
            this.rbtnHard.TabIndex = 4;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = false;
            this.rbtnHard.Click += new System.EventHandler(this.CammonRadioButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtnEasy);
            this.groupBox1.Controls.Add(this.rbtnHard);
            this.groupBox1.Controls.Add(this.rbtnMiddle);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Difficulty";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(173, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(339, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // lblPasswordSecurity
            // 
            this.lblPasswordSecurity.AutoSize = true;
            this.lblPasswordSecurity.BackColor = System.Drawing.Color.White;
            this.lblPasswordSecurity.Location = new System.Drawing.Point(13, 86);
            this.lblPasswordSecurity.Name = "lblPasswordSecurity";
            this.lblPasswordSecurity.Size = new System.Drawing.Size(154, 18);
            this.lblPasswordSecurity.TabIndex = 7;
            this.lblPasswordSecurity.Text = "Password Security:";
            // 
            // btnMake
            // 
            this.btnMake.BackColor = System.Drawing.Color.White;
            this.btnMake.ForeColor = System.Drawing.Color.Black;
            this.btnMake.Location = new System.Drawing.Point(15, 147);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 27);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "Create";
            this.btnMake.UseVisualStyleBackColor = false;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(517, 91);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 18);
            this.lblPercent.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblCreatedPassword
            // 
            this.lblCreatedPassword.AutoSize = true;
            this.lblCreatedPassword.BackColor = System.Drawing.Color.White;
            this.lblCreatedPassword.Location = new System.Drawing.Point(13, 118);
            this.lblCreatedPassword.Name = "lblCreatedPassword";
            this.lblCreatedPassword.Size = new System.Drawing.Size(171, 18);
            this.lblCreatedPassword.TabIndex = 7;
            this.lblCreatedPassword.Text = "Generated Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(192, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 18);
            this.lblPassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 186);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCreatedPassword);
            this.Controls.Add(this.lblPasswordSecurity);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.cboxLenght);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CrongPassword";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.RadioButton rbtnEasy;
        private System.Windows.Forms.RadioButton rbtnMiddle;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPasswordSecurity;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ComboBox cboxLenght;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCreatedPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}

