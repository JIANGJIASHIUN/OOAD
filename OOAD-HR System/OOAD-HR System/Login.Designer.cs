﻿namespace OOAD_HR_System
{
    partial class _login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._welcomeText = new System.Windows.Forms.Label();
            this._emplIdTitle = new System.Windows.Forms.Label();
            this._passwdTitle = new System.Windows.Forms.Label();
            this._employeeID = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.TextBox();
            this._loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _welcomeText
            // 
            this._welcomeText.AutoSize = true;
            this._welcomeText.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._welcomeText.Location = new System.Drawing.Point(8, 21);
            this._welcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._welcomeText.Name = "_welcomeText";
            this._welcomeText.Size = new System.Drawing.Size(442, 27);
            this._welcomeText.TabIndex = 0;
            this._welcomeText.Text = "Welcome to Human Resource System!";
            // 
            // _emplIdTitle
            // 
            this._emplIdTitle.AutoSize = true;
            this._emplIdTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._emplIdTitle.Location = new System.Drawing.Point(73, 103);
            this._emplIdTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._emplIdTitle.Name = "_emplIdTitle";
            this._emplIdTitle.Size = new System.Drawing.Size(111, 19);
            this._emplIdTitle.TabIndex = 1;
            this._emplIdTitle.Text = "Employee ID:";
            // 
            // _passwdTitle
            // 
            this._passwdTitle.AutoSize = true;
            this._passwdTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._passwdTitle.Location = new System.Drawing.Point(73, 151);
            this._passwdTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._passwdTitle.Name = "_passwdTitle";
            this._passwdTitle.Size = new System.Drawing.Size(83, 19);
            this._passwdTitle.TabIndex = 2;
            this._passwdTitle.Text = "Password:";
            // 
            // _employeeID
            // 
            this._employeeID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employeeID.Location = new System.Drawing.Point(184, 98);
            this._employeeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._employeeID.Name = "_employeeID";
            this._employeeID.Size = new System.Drawing.Size(189, 27);
            this._employeeID.TabIndex = 3;
            // 
            // _password
            // 
            this._password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._password.Location = new System.Drawing.Point(157, 146);
            this._password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(216, 27);
            this._password.TabIndex = 4;
            this._password.UseSystemPasswordChar = true;
            // 
            // _loginButton
            // 
            this._loginButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._loginButton.Location = new System.Drawing.Point(297, 201);
            this._loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 31);
            this._loginButton.TabIndex = 5;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this.ClickLoginButton);
            // 
            // _login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 254);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._password);
            this.Controls.Add(this._employeeID);
            this.Controls.Add(this._passwdTitle);
            this.Controls.Add(this._emplIdTitle);
            this.Controls.Add(this._welcomeText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "_login";
            this.Text = "Human Resource System Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _welcomeText;
        private System.Windows.Forms.Label _emplIdTitle;
        private System.Windows.Forms.Label _passwdTitle;
        private System.Windows.Forms.TextBox _employeeID;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Button _loginButton;
    }
}

