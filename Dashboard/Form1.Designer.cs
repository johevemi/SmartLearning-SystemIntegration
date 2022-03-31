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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRestPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetSqlData = new System.Windows.Forms.Button();
            this.dataGridViewSqlData = new System.Windows.Forms.DataGridView();
            this.textBoxSqlServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSqlUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSqlPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSqlData)).BeginInit();
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
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(77, 163);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(395, 23);
            this.textBoxPath.TabIndex = 8;
            this.textBoxPath.Text = "https://localhost:44308/WeatherForecast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "REST Path";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(478, 162);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 11;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 246);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBoxRestPassword
            // 
            this.textBoxRestPassword.Location = new System.Drawing.Point(628, 162);
            this.textBoxRestPassword.Name = "textBoxRestPassword";
            this.textBoxRestPassword.Size = new System.Drawing.Size(160, 23);
            this.textBoxRestPassword.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // GetSqlData
            // 
            this.GetSqlData.Location = new System.Drawing.Point(713, 499);
            this.GetSqlData.Name = "GetSqlData";
            this.GetSqlData.Size = new System.Drawing.Size(75, 23);
            this.GetSqlData.TabIndex = 15;
            this.GetSqlData.Text = "Get";
            this.GetSqlData.UseVisualStyleBackColor = true;
            this.GetSqlData.Click += new System.EventHandler(this.GetSqlData_Click);
            // 
            // dataGridViewSqlData
            // 
            this.dataGridViewSqlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSqlData.Location = new System.Drawing.Point(12, 528);
            this.dataGridViewSqlData.Name = "dataGridViewSqlData";
            this.dataGridViewSqlData.RowTemplate.Height = 25;
            this.dataGridViewSqlData.Size = new System.Drawing.Size(776, 209);
            this.dataGridViewSqlData.TabIndex = 16;
            // 
            // textBoxSqlServer
            // 
            this.textBoxSqlServer.Location = new System.Drawing.Point(113, 441);
            this.textBoxSqlServer.Name = "textBoxSqlServer";
            this.textBoxSqlServer.Size = new System.Drawing.Size(231, 23);
            this.textBoxSqlServer.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "SqlServer";
            // 
            // textBoxSqlUserName
            // 
            this.textBoxSqlUserName.Location = new System.Drawing.Point(113, 470);
            this.textBoxSqlUserName.Name = "textBoxSqlUserName";
            this.textBoxSqlUserName.Size = new System.Drawing.Size(231, 23);
            this.textBoxSqlUserName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "SqlUserName";
            // 
            // textBoxSqlPassword
            // 
            this.textBoxSqlPassword.Location = new System.Drawing.Point(113, 499);
            this.textBoxSqlPassword.Name = "textBoxSqlPassword";
            this.textBoxSqlPassword.Size = new System.Drawing.Size(231, 23);
            this.textBoxSqlPassword.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "SqlPassword";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(713, 836);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 23;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 840);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Save input secrets to file in documents";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 871);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSqlPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSqlUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSqlServer);
            this.Controls.Add(this.dataGridViewSqlData);
            this.Controls.Add(this.GetSqlData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRestPassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPath);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSqlData)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRestPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetSqlData;
        private System.Windows.Forms.DataGridView dataGridViewSqlData;
        private System.Windows.Forms.TextBox textBoxSqlServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSqlUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSqlPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
    }
}
