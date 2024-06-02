namespace Enunciado1
{
    partial class buscadorProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_buscador = new System.Windows.Forms.DataGridView();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_buscador = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscador)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1071, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tabla";
            // 
            // dgv_buscador
            // 
            this.dgv_buscador.AllowUserToAddRows = false;
            this.dgv_buscador.AllowUserToDeleteRows = false;
            this.dgv_buscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscador.Location = new System.Drawing.Point(877, 100);
            this.dgv_buscador.Name = "dgv_buscador";
            this.dgv_buscador.ShowEditingIcon = false;
            this.dgv_buscador.Size = new System.Drawing.Size(546, 480);
            this.dgv_buscador.TabIndex = 10;
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.Location = new System.Drawing.Point(262, 253);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(297, 33);
            this.txt_buscador.TabIndex = 15;
            this.txt_buscador.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre Producto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscador";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(368, 304);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 38);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_productos,
            this.tsmi_buscador});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_productos
            // 
            this.tsmi_productos.Name = "tsmi_productos";
            this.tsmi_productos.Size = new System.Drawing.Size(150, 20);
            this.tsmi_productos.Text = "Formulario de Productos";
            this.tsmi_productos.Click += new System.EventHandler(this.tsmi_productos_Click);
            // 
            // tsmi_buscador
            // 
            this.tsmi_buscador.Enabled = false;
            this.tsmi_buscador.Name = "tsmi_buscador";
            this.tsmi_buscador.Size = new System.Drawing.Size(141, 20);
            this.tsmi_buscador.Text = "Buscador de Productos";
            // 
            // buscadorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_buscador);
            this.Name = "buscadorProducto";
            this.Text = "buscadorProducto";
            this.Load += new System.EventHandler(this.buscadorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscador)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_buscador;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_productos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_buscador;
    }
}