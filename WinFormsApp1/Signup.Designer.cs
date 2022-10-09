namespace WinFormsApp1
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signupUserBox = new System.Windows.Forms.TextBox();
            this.signupPassBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // signupUserBox
            // 
            this.signupUserBox.Location = new System.Drawing.Point(288, 94);
            this.signupUserBox.Name = "signupUserBox";
            this.signupUserBox.Size = new System.Drawing.Size(121, 23);
            this.signupUserBox.TabIndex = 2;
            // 
            // signupPassBox
            // 
            this.signupPassBox.Location = new System.Drawing.Point(288, 184);
            this.signupPassBox.Name = "signupPassBox";
            this.signupPassBox.PasswordChar = '*';
            this.signupPassBox.Size = new System.Drawing.Size(121, 23);
            this.signupPassBox.TabIndex = 3;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(288, 231);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(134, 49);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SIGN UP";
            // 
            // toLoginButton
            // 
            this.toLoginButton.Location = new System.Drawing.Point(256, 298);
            this.toLoginButton.Name = "toLoginButton";
            this.toLoginButton.Size = new System.Drawing.Size(249, 32);
            this.toLoginButton.TabIndex = 6;
            this.toLoginButton.Text = "Ya tengo un usuario";
            this.toLoginButton.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Background_chico_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signupPassBox);
            this.Controls.Add(this.signupUserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox signupUserBox;
        private TextBox signupPassBox;
        private Button signupButton;
        private Label label3;
        private Button toLoginButton;
    }
}