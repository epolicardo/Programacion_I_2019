namespace ABMLista
{
    partial class frm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAgregar = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(644, 15);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(16, 15);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(619, 22);
            this.txt.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(16, 48);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 17);
            this.lbl.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(644, 48);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 28);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(644, 85);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 28);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 263);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(619, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frm
            // 
            this.AcceptButton = this.btAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm";
            this.Text = "Manejo de lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

