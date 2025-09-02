namespace Wform02092025
{
    partial class Hola
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nombre
            // 
            this.lb_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_nombre.Font = new System.Drawing.Font("ISOCPEUR", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(0, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(866, 37);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Ingrese su nombre";
            this.lb_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(325, 50);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(225, 33);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_guardar.Location = new System.Drawing.Point(338, 99);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(195, 41);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar nombre";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_salir.Location = new System.Drawing.Point(375, 146);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 49);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Hola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(866, 466);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Name = "Hola";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
    }
}

