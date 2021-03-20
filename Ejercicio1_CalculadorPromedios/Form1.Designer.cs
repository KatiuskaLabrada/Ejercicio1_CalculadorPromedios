namespace Ejercicio1_CalculadorPromedios
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
            this.titulo = new System.Windows.Forms.Label();
            this.labelCal1 = new System.Windows.Forms.Label();
            this.labelCal2 = new System.Windows.Forms.Label();
            this.labelCal3 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.cal1 = new System.Windows.Forms.TextBox();
            this.cal2 = new System.Windows.Forms.TextBox();
            this.cal3 = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(372, 46);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(247, 24);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Calculadora de Promedio";
            // 
            // labelCal1
            // 
            this.labelCal1.AutoSize = true;
            this.labelCal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCal1.Location = new System.Drawing.Point(147, 124);
            this.labelCal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCal1.Name = "labelCal1";
            this.labelCal1.Size = new System.Drawing.Size(110, 18);
            this.labelCal1.TabIndex = 1;
            this.labelCal1.Text = "Calificación 1";
            // 
            // labelCal2
            // 
            this.labelCal2.AutoSize = true;
            this.labelCal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCal2.Location = new System.Drawing.Point(147, 197);
            this.labelCal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCal2.Name = "labelCal2";
            this.labelCal2.Size = new System.Drawing.Size(110, 18);
            this.labelCal2.TabIndex = 2;
            this.labelCal2.Text = "Calificación 2";
            // 
            // labelCal3
            // 
            this.labelCal3.AutoSize = true;
            this.labelCal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCal3.Location = new System.Drawing.Point(147, 258);
            this.labelCal3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCal3.Name = "labelCal3";
            this.labelCal3.Size = new System.Drawing.Size(110, 18);
            this.labelCal3.TabIndex = 3;
            this.labelCal3.Text = "Calificación 3";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.Location = new System.Drawing.Point(485, 319);
            this.labelRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(91, 20);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "Resultado";
            // 
            // cal1
            // 
            this.cal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal1.Location = new System.Drawing.Point(368, 122);
            this.cal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(130, 24);
            this.cal1.TabIndex = 6;
            // 
            // cal2
            // 
            this.cal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal2.Location = new System.Drawing.Point(368, 190);
            this.cal2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cal2.Name = "cal2";
            this.cal2.Size = new System.Drawing.Size(130, 24);
            this.cal2.TabIndex = 7;
            // 
            // cal3
            // 
            this.cal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal3.Location = new System.Drawing.Point(368, 251);
            this.cal3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cal3.Name = "cal3";
            this.cal3.Size = new System.Drawing.Size(130, 24);
            this.cal3.TabIndex = 8;
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(472, 359);
            this.res.Margin = new System.Windows.Forms.Padding(4);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(130, 24);
            this.res.TabIndex = 9;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(684, 116);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(124, 30);
            this.btnCal.TabIndex = 10;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(684, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 462);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.res);
            this.Controls.Add(this.cal3);
            this.Controls.Add(this.cal2);
            this.Controls.Add(this.cal1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelCal3);
            this.Controls.Add(this.labelCal2);
            this.Controls.Add(this.labelCal1);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label labelCal1;
        private System.Windows.Forms.Label labelCal2;
        private System.Windows.Forms.Label labelCal3;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox cal1;
        private System.Windows.Forms.TextBox cal2;
        private System.Windows.Forms.TextBox cal3;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

