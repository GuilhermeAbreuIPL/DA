namespace Ficha2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelHours = new ToolStripStatusLabel();
            toolStripStatusLabelContador = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            button_start_stop = new Button();
            button_reset = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelHours, toolStripStatusLabelContador });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHours
            // 
            toolStripStatusLabelHours.Name = "toolStripStatusLabelHours";
            toolStripStatusLabelHours.Size = new Size(63, 20);
            toolStripStatusLabelHours.Text = "00:00:00";
            toolStripStatusLabelHours.Click += toolStripStatusLabelHours_Click;
            // 
            // toolStripStatusLabelContador
            // 
            toolStripStatusLabelContador.Name = "toolStripStatusLabelContador";
            toolStripStatusLabelContador.Size = new Size(63, 20);
            toolStripStatusLabelContador.Text = "00:00:00";
            toolStripStatusLabelContador.Click += toolStripStatusLabelContador_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button_start_stop
            // 
            button_start_stop.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button_start_stop.Location = new Point(281, 126);
            button_start_stop.Name = "button_start_stop";
            button_start_stop.Size = new Size(192, 95);
            button_start_stop.TabIndex = 1;
            button_start_stop.Text = "STOP";
            button_start_stop.UseVisualStyleBackColor = true;
            button_start_stop.Click += button_start_stop_Click;
            // 
            // button_reset
            // 
            button_reset.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_reset.Location = new Point(603, 342);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(163, 63);
            button_reset.TabIndex = 2;
            button_reset.Text = "RESET";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_reset);
            Controls.Add(button_start_stop);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "A Minha Aplicação";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelHours;
        private ToolStripStatusLabel toolStripStatusLabelContador;
        private System.Windows.Forms.Timer timer1;
        private Button button_start_stop;
        private Button button_reset;
    }
}
