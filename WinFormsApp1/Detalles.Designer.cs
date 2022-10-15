namespace WinFormsApp1
{
    partial class Detalles
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
            System.Windows.Forms.Button modificarCaja;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminarCaja = new System.Windows.Forms.Button();
            this.depositar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.transferir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            modificarCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modificarCaja
            // 
            modificarCaja.Enabled = false;
            modificarCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            modificarCaja.FlatAppearance.BorderSize = 2;
            modificarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            modificarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            modificarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            modificarCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            modificarCaja.ForeColor = System.Drawing.Color.White;
            modificarCaja.Location = new System.Drawing.Point(256, 276);
            modificarCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modificarCaja.Name = "modificarCaja";
            modificarCaja.Size = new System.Drawing.Size(100, 38);
            modificarCaja.TabIndex = 36;
            modificarCaja.Text = "Modificar Caja";
            modificarCaja.UseVisualStyleBackColor = true;
            modificarCaja.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(96, 163);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(616, 47);
            this.dataGridView1.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Movimientos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuario: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "__________________";
            // 
            // eliminarCaja
            // 
            this.eliminarCaja.Enabled = false;
            this.eliminarCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eliminarCaja.FlatAppearance.BorderSize = 2;
            this.eliminarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliminarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eliminarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eliminarCaja.ForeColor = System.Drawing.Color.White;
            this.eliminarCaja.Location = new System.Drawing.Point(150, 276);
            this.eliminarCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarCaja.Name = "eliminarCaja";
            this.eliminarCaja.Size = new System.Drawing.Size(100, 38);
            this.eliminarCaja.TabIndex = 37;
            this.eliminarCaja.Text = "Eliminar Caja";
            this.eliminarCaja.UseVisualStyleBackColor = true;
            this.eliminarCaja.Visible = false;
            // 
            // depositar
            // 
            this.depositar.Enabled = false;
            this.depositar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.depositar.FlatAppearance.BorderSize = 2;
            this.depositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositar.ForeColor = System.Drawing.Color.White;
            this.depositar.Location = new System.Drawing.Point(362, 276);
            this.depositar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositar.Name = "depositar";
            this.depositar.Size = new System.Drawing.Size(100, 38);
            this.depositar.TabIndex = 35;
            this.depositar.Text = "Depositar";
            this.depositar.UseVisualStyleBackColor = true;
            this.depositar.Visible = false;
            // 
            // retirar
            // 
            this.retirar.Enabled = false;
            this.retirar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.retirar.FlatAppearance.BorderSize = 2;
            this.retirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retirar.ForeColor = System.Drawing.Color.White;
            this.retirar.Location = new System.Drawing.Point(468, 276);
            this.retirar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(100, 38);
            this.retirar.TabIndex = 34;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Visible = false;
            // 
            // transferir
            // 
            this.transferir.Enabled = false;
            this.transferir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.transferir.FlatAppearance.BorderSize = 2;
            this.transferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.transferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.transferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transferir.ForeColor = System.Drawing.Color.White;
            this.transferir.Location = new System.Drawing.Point(574, 276);
            this.transferir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferir.Name = "transferir";
            this.transferir.Size = new System.Drawing.Size(100, 38);
            this.transferir.TabIndex = 33;
            this.transferir.Text = "Transferir";
            this.transferir.UseVisualStyleBackColor = true;
            this.transferir.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ir Atrás";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "CBU:";
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eliminarCaja);
            this.Controls.Add(modificarCaja);
            this.Controls.Add(this.depositar);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.transferir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detalles";
            this.Text = "Detalles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button eliminarCaja;
        private Button depositar;
        private Button retirar;
        private Button transferir;
        private Button button1;
        private Label label1;
        private Label label3;
    }
}