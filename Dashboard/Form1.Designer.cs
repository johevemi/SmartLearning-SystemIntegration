namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEnergyForTheHour = new System.Windows.Forms.TextBox();
            this.textBoxRequestUriString = new System.Windows.Forms.TextBox();
            this.requestUriString = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SolarPanel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEnergyForTheHour
            // 
            this.textBoxEnergyForTheHour.Location = new System.Drawing.Point(12, 89);
            this.textBoxEnergyForTheHour.Name = "textBoxEnergyForTheHour";
            this.textBoxEnergyForTheHour.ReadOnly = true;
            this.textBoxEnergyForTheHour.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnergyForTheHour.TabIndex = 1;
            // 
            // textBoxRequestUriString
            // 
            this.textBoxRequestUriString.Location = new System.Drawing.Point(113, 6);
            this.textBoxRequestUriString.Name = "textBoxRequestUriString";
            this.textBoxRequestUriString.Size = new System.Drawing.Size(675, 23);
            this.textBoxRequestUriString.TabIndex = 2;
            // 
            // requestUriString
            // 
            this.requestUriString.AutoSize = true;
            this.requestUriString.Location = new System.Drawing.Point(12, 9);
            this.requestUriString.Name = "requestUriString";
            this.requestUriString.Size = new System.Drawing.Size(95, 15);
            this.requestUriString.TabIndex = 3;
            this.requestUriString.Text = "RequestUriString";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(45, 38);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(62, 15);
            this.userName.TabIndex = 4;
            this.userName.Text = "UserName";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(113, 35);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(225, 23);
            this.textBoxUserName.TabIndex = 5;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(344, 38);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 15);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(407, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(381, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.requestUriString);
            this.Controls.Add(this.textBoxRequestUriString);
            this.Controls.Add(this.textBoxEnergyForTheHour);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEnergyForTheHour;
        private System.Windows.Forms.TextBox textBoxRequestUriString;
        private System.Windows.Forms.Label requestUriString;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}
