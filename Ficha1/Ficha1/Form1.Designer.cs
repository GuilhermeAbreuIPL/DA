namespace Ficha1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_hours = new System.Windows.Forms.Label();
            this.button_hours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hours
            // 
            this.label_hours.AutoSize = true;
            this.label_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hours.Location = new System.Drawing.Point(85, 39);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(48, 20);
            this.label_hours.TabIndex = 0;
            this.label_hours.Text = "vazio";
            this.label_hours.Click += new System.EventHandler(this.label_Button_Click);
            // 
            // button_hours
            // 
            this.button_hours.BackColor = System.Drawing.Color.Red;
            this.button_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hours.ForeColor = System.Drawing.Color.Green;
            this.button_hours.Location = new System.Drawing.Point(55, 85);
            this.button_hours.Name = "button_hours";
            this.button_hours.Size = new System.Drawing.Size(135, 76);
            this.button_hours.TabIndex = 1;
            this.button_hours.Text = "Que horas são?";
            this.button_hours.UseVisualStyleBackColor = false;
            this.button_hours.Click += new System.EventHandler(this.label_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 200);
            this.Controls.Add(this.button_hours);
            this.Controls.Add(this.label_hours);
            this.Name = "Form1";
            this.Text = "Ficha 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Button button_hours;
    }
}

