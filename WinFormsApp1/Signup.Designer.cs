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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signupUserBox = new System.Windows.Forms.TextBox();
            this.signupPassBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toLoginButton = new System.Windows.Forms.Button();
            this.signupPassBoxConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // signupUserBox
            // 
            this.signupUserBox.Location = new System.Drawing.Point(307, 107);
            this.signupUserBox.Name = "signupUserBox";
            this.signupUserBox.Size = new System.Drawing.Size(134, 23);
            this.signupUserBox.TabIndex = 2;
            // 
            // signupPassBox
            // 
            this.signupPassBox.Location = new System.Drawing.Point(307, 149);
            this.signupPassBox.Name = "signupPassBox";
            this.signupPassBox.PasswordChar = '*';
            this.signupPassBox.PlaceholderText = "12345678";
            this.signupPassBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signupPassBox.Size = new System.Drawing.Size(134, 23);
            this.signupPassBox.TabIndex = 3;
            // 
            // signupButton
            // 
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Location = new System.Drawing.Point(307, 240);
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "BIENVENIDO";
            // 
            // toLoginButton
            // 
            this.toLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.toLoginButton.FlatAppearance.BorderSize = 0;
            this.toLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toLoginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLoginButton.ForeColor = System.Drawing.Color.White;
            this.toLoginButton.Location = new System.Drawing.Point(250, 390);
            this.toLoginButton.Name = "toLoginButton";
            this.toLoginButton.Size = new System.Drawing.Size(249, 32);
            this.toLoginButton.TabIndex = 6;
            this.toLoginButton.Text = "Ya tengo un usuario";
            this.toLoginButton.UseVisualStyleBackColor = false;
            // 
            // signupPassBoxConfirm
            // 
            this.signupPassBoxConfirm.Location = new System.Drawing.Point(307, 190);
            this.signupPassBoxConfirm.Name = "signupPassBoxConfirm";
            this.signupPassBoxConfirm.PasswordChar = '*';
            this.signupPassBoxConfirm.PlaceholderText = "12345678";
            this.signupPassBoxConfirm.Size = new System.Drawing.Size(134, 23);
            this.signupPassBoxConfirm.TabIndex = 7;
            this.signupPassBoxConfirm.TextChanged += new System.EventHandler(this.signupPassBoxConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(173, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Background_chico_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signupPassBoxConfirm);
            this.Controls.Add(this.toLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signupPassBox);
            this.Controls.Add(this.signupUserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private TextBox signupPassBoxConfirm;
        private Label label4;
    }
}