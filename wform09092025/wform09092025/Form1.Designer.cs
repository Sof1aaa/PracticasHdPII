namespace wform09092025
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbdsum = new System.Windows.Forms.RadioButton();
            this.rbdres = new System.Windows.Forms.RadioButton();
            this.rbddiv = new System.Windows.Forms.RadioButton();
            this.rbdmul = new System.Windows.Forms.RadioButton();
            this.rbdFibo = new System.Windows.Forms.RadioButton();
            this.rbdSumatoria = new System.Windows.Forms.RadioButton();
            this.rbdFac = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // txt1
            // 
            this.txt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt1.Location = new System.Drawing.Point(278, 173);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn.Location = new System.Drawing.Point(777, 504);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(128, 57);
            this.btn.TabIndex = 2;
            this.btn.Text = "Ejecutar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt2
            // 
            this.txt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt2.Location = new System.Drawing.Point(424, 173);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(419, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2";
            // 
            // txt3
            // 
            this.txt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt3.Location = new System.Drawing.Point(576, 173);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(571, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número 3";
            // 
            // rbdsum
            // 
            this.rbdsum.AutoSize = true;
            this.rbdsum.BackColor = System.Drawing.Color.Transparent;
            this.rbdsum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdsum.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdsum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdsum.Location = new System.Drawing.Point(169, 285);
            this.rbdsum.Name = "rbdsum";
            this.rbdsum.Size = new System.Drawing.Size(61, 20);
            this.rbdsum.TabIndex = 7;
            this.rbdsum.TabStop = true;
            this.rbdsum.Text = "Suma";
            this.rbdsum.UseVisualStyleBackColor = false;
            // 
            // rbdres
            // 
            this.rbdres.AutoSize = true;
            this.rbdres.BackColor = System.Drawing.Color.Transparent;
            this.rbdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdres.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdres.Location = new System.Drawing.Point(169, 311);
            this.rbdres.Name = "rbdres";
            this.rbdres.Size = new System.Drawing.Size(60, 20);
            this.rbdres.TabIndex = 7;
            this.rbdres.TabStop = true;
            this.rbdres.Text = "Resta";
            this.rbdres.UseVisualStyleBackColor = false;
            // 
            // rbddiv
            // 
            this.rbddiv.AutoSize = true;
            this.rbddiv.BackColor = System.Drawing.Color.Transparent;
            this.rbddiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbddiv.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbddiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbddiv.Location = new System.Drawing.Point(169, 363);
            this.rbddiv.Name = "rbddiv";
            this.rbddiv.Size = new System.Drawing.Size(72, 20);
            this.rbddiv.TabIndex = 7;
            this.rbddiv.TabStop = true;
            this.rbddiv.Text = "División";
            this.rbddiv.UseVisualStyleBackColor = false;
            // 
            // rbdmul
            // 
            this.rbdmul.AutoSize = true;
            this.rbdmul.BackColor = System.Drawing.Color.Transparent;
            this.rbdmul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdmul.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdmul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdmul.Location = new System.Drawing.Point(169, 337);
            this.rbdmul.Name = "rbdmul";
            this.rbdmul.Size = new System.Drawing.Size(114, 20);
            this.rbdmul.TabIndex = 7;
            this.rbdmul.TabStop = true;
            this.rbdmul.Text = "Multiplicación";
            this.rbdmul.UseVisualStyleBackColor = false;
            // 
            // rbdFibo
            // 
            this.rbdFibo.AutoSize = true;
            this.rbdFibo.BackColor = System.Drawing.Color.Transparent;
            this.rbdFibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdFibo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdFibo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdFibo.Location = new System.Drawing.Point(169, 438);
            this.rbdFibo.Name = "rbdFibo";
            this.rbdFibo.Size = new System.Drawing.Size(87, 20);
            this.rbdFibo.TabIndex = 9;
            this.rbdFibo.TabStop = true;
            this.rbdFibo.Text = "Fibonacci";
            this.rbdFibo.UseVisualStyleBackColor = false;
            // 
            // rbdSumatoria
            // 
            this.rbdSumatoria.AutoSize = true;
            this.rbdSumatoria.BackColor = System.Drawing.Color.Transparent;
            this.rbdSumatoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdSumatoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSumatoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdSumatoria.Location = new System.Drawing.Point(169, 412);
            this.rbdSumatoria.Name = "rbdSumatoria";
            this.rbdSumatoria.Size = new System.Drawing.Size(90, 20);
            this.rbdSumatoria.TabIndex = 11;
            this.rbdSumatoria.TabStop = true;
            this.rbdSumatoria.Text = "Sumatoria";
            this.rbdSumatoria.UseVisualStyleBackColor = false;
            // 
            // rbdFac
            // 
            this.rbdFac.AutoSize = true;
            this.rbdFac.BackColor = System.Drawing.Color.Transparent;
            this.rbdFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdFac.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdFac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbdFac.Location = new System.Drawing.Point(169, 386);
            this.rbdFac.Name = "rbdFac";
            this.rbdFac.Size = new System.Drawing.Size(80, 20);
            this.rbdFac.TabIndex = 12;
            this.rbdFac.Text = "Factorial";
            this.rbdFac.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wform09092025.Properties.Resources.Space_Background_Images;
            this.ClientSize = new System.Drawing.Size(941, 573);
            this.Controls.Add(this.rbdFibo);
            this.Controls.Add(this.rbdSumatoria);
            this.Controls.Add(this.rbdFac);
            this.Controls.Add(this.rbdmul);
            this.Controls.Add(this.rbddiv);
            this.Controls.Add(this.rbdres);
            this.Controls.Add(this.rbdsum);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbdsum;
        private System.Windows.Forms.RadioButton rbdres;
        private System.Windows.Forms.RadioButton rbddiv;
        private System.Windows.Forms.RadioButton rbdmul;
        private System.Windows.Forms.RadioButton rbdFibo;
        private System.Windows.Forms.RadioButton rbdSumatoria;
        private System.Windows.Forms.RadioButton rbdFac;
    }
}

