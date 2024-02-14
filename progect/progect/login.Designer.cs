namespace progect
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.USER_PASSWORD = new System.Windows.Forms.TextBox();
            this.USER_NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // USER_PASSWORD
            // 
            this.USER_PASSWORD.Location = new System.Drawing.Point(474, 149);
            this.USER_PASSWORD.Name = "USER_PASSWORD";
            this.USER_PASSWORD.Size = new System.Drawing.Size(100, 20);
            this.USER_PASSWORD.TabIndex = 1;
            // 
            // USER_NAME
            // 
            this.USER_NAME.Location = new System.Drawing.Point(474, 106);
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.Size = new System.Drawing.Size(100, 20);
            this.USER_NAME.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.USER_NAME);
            this.Controls.Add(this.USER_PASSWORD);
         //   this.Controls.Add(this.button1);
            this.Name = "login";
            this.Text = "login";
           // this.Load += new System.EventHandler(this.login.Load);
         //   this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox USER_PASSWORD;
        private System.Windows.Forms.TextBox USER_NAME;
    }
}