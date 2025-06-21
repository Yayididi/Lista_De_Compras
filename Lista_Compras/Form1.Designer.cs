namespace Lista_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Articulolb = new System.Windows.Forms.Label();
            this.CantEstlb = new System.Windows.Forms.Label();
            this.PrecioEstlb = new System.Windows.Forms.Label();
            this.TotalEstlb = new System.Windows.Forms.Label();
            this.PrecioReallb = new System.Windows.Forms.Label();
            this.TotalReallb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PrecioEsttxt = new System.Windows.Forms.TextBox();
            this.CantEsttxt = new System.Windows.Forms.TextBox();
            this.txtPrecioReal = new System.Windows.Forms.TextBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Registrarbtn = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEncontrado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // Articulolb
            // 
            this.Articulolb.AutoSize = true;
            this.Articulolb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulolb.Location = new System.Drawing.Point(58, 101);
            this.Articulolb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Articulolb.Name = "Articulolb";
            this.Articulolb.Size = new System.Drawing.Size(79, 19);
            this.Articulolb.TabIndex = 0;
            this.Articulolb.Text = "Articulo:";
            // 
            // CantEstlb
            // 
            this.CantEstlb.AutoSize = true;
            this.CantEstlb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantEstlb.Location = new System.Drawing.Point(271, 101);
            this.CantEstlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantEstlb.Name = "CantEstlb";
            this.CantEstlb.Size = new System.Drawing.Size(167, 19);
            this.CantEstlb.TabIndex = 1;
            this.CantEstlb.Text = "Cantidad Estimada:";
            // 
            // PrecioEstlb
            // 
            this.PrecioEstlb.AutoSize = true;
            this.PrecioEstlb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioEstlb.Location = new System.Drawing.Point(484, 101);
            this.PrecioEstlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioEstlb.Name = "PrecioEstlb";
            this.PrecioEstlb.Size = new System.Drawing.Size(145, 19);
            this.PrecioEstlb.TabIndex = 2;
            this.PrecioEstlb.Text = "Precio Estimado:";
            // 
            // TotalEstlb
            // 
            this.TotalEstlb.AutoSize = true;
            this.TotalEstlb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEstlb.Location = new System.Drawing.Point(698, 101);
            this.TotalEstlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalEstlb.Name = "TotalEstlb";
            this.TotalEstlb.Size = new System.Drawing.Size(135, 19);
            this.TotalEstlb.TabIndex = 3;
            this.TotalEstlb.Text = "Total Estimado:";
            // 
            // PrecioReallb
            // 
            this.PrecioReallb.AutoSize = true;
            this.PrecioReallb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioReallb.Location = new System.Drawing.Point(271, 183);
            this.PrecioReallb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioReallb.Name = "PrecioReallb";
            this.PrecioReallb.Size = new System.Drawing.Size(106, 19);
            this.PrecioReallb.TabIndex = 5;
            this.PrecioReallb.Text = "Precio Real:";
            // 
            // TotalReallb
            // 
            this.TotalReallb.AutoSize = true;
            this.TotalReallb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReallb.Location = new System.Drawing.Point(484, 183);
            this.TotalReallb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalReallb.Name = "TotalReallb";
            this.TotalReallb.Size = new System.Drawing.Size(96, 19);
            this.TotalReallb.TabIndex = 6;
            this.TotalReallb.Text = "Total Real:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 47);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lista de Compras";
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.txtArticulo.Location = new System.Drawing.Point(63, 124);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(164, 26);
            this.txtArticulo.TabIndex = 8;
            this.txtArticulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.textBox2.Location = new System.Drawing.Point(490, 207);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.textBox4.Location = new System.Drawing.Point(703, 124);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 26);
            this.textBox4.TabIndex = 11;
            // 
            // PrecioEsttxt
            // 
            this.PrecioEsttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PrecioEsttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.PrecioEsttxt.Location = new System.Drawing.Point(490, 124);
            this.PrecioEsttxt.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioEsttxt.Name = "PrecioEsttxt";
            this.PrecioEsttxt.Size = new System.Drawing.Size(164, 26);
            this.PrecioEsttxt.TabIndex = 12;
            // 
            // CantEsttxt
            // 
            this.CantEsttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CantEsttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.CantEsttxt.Location = new System.Drawing.Point(277, 124);
            this.CantEsttxt.Margin = new System.Windows.Forms.Padding(4);
            this.CantEsttxt.Name = "CantEsttxt";
            this.CantEsttxt.Size = new System.Drawing.Size(164, 26);
            this.CantEsttxt.TabIndex = 13;
            // 
            // txtPrecioReal
            // 
            this.txtPrecioReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecioReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.txtPrecioReal.Location = new System.Drawing.Point(277, 207);
            this.txtPrecioReal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioReal.Name = "txtPrecioReal";
            this.txtPrecioReal.Size = new System.Drawing.Size(164, 26);
            this.txtPrecioReal.TabIndex = 14;
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.Updatebtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.Updatebtn.Location = new System.Drawing.Point(98, 494);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(211, 51);
            this.Updatebtn.TabIndex = 15;
            this.Updatebtn.Text = "Actualizar";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.Registrarbtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.Registrarbtn.Location = new System.Drawing.Point(687, 494);
            this.Registrarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Size = new System.Drawing.Size(211, 51);
            this.Registrarbtn.TabIndex = 16;
            this.Registrarbtn.Text = "Registrar";
            this.Registrarbtn.UseVisualStyleBackColor = false;
            this.Registrarbtn.Click += new System.EventHandler(this.Registrarbtn_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCompras.Location = new System.Drawing.Point(62, 319);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(877, 158);
            this.dgvCompras.TabIndex = 17;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Registro";
            // 
            // chkEncontrado
            // 
            this.chkEncontrado.AutoSize = true;
            this.chkEncontrado.Location = new System.Drawing.Point(63, 207);
            this.chkEncontrado.Name = "chkEncontrado";
            this.chkEncontrado.Size = new System.Drawing.Size(127, 23);
            this.chkEncontrado.TabIndex = 19;
            this.chkEncontrado.Text = "Encontrado?";
            this.chkEncontrado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(74)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1004, 567);
            this.Controls.Add(this.chkEncontrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.Registrarbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.txtPrecioReal);
            this.Controls.Add(this.CantEsttxt);
            this.Controls.Add(this.PrecioEsttxt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalReallb);
            this.Controls.Add(this.PrecioReallb);
            this.Controls.Add(this.TotalEstlb);
            this.Controls.Add(this.PrecioEstlb);
            this.Controls.Add(this.CantEstlb);
            this.Controls.Add(this.Articulolb);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registro_Lista_de_Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Articulolb;
        private System.Windows.Forms.Label CantEstlb;
        private System.Windows.Forms.Label PrecioEstlb;
        private System.Windows.Forms.Label TotalEstlb;
        private System.Windows.Forms.Label PrecioReallb;
        private System.Windows.Forms.Label TotalReallb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PrecioEsttxt;
        private System.Windows.Forms.TextBox CantEsttxt;
        private System.Windows.Forms.TextBox txtPrecioReal;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Registrarbtn;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEncontrado;
    }
}

