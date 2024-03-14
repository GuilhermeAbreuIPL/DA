namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendarNascimento = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            this.buttonPontuar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumeroAluno = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxDificuldade = new System.Windows.Forms.TextBox();
            this.buttonAluno = new System.Windows.Forms.Button();
            this.buttonAlunoEspecial = new System.Windows.Forms.Button();
            this.buttonProfessor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCargo = new System.Windows.Forms.Button();
            this.textBoxDados = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 38);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // monthCalendarNascimento
            // 
            this.monthCalendarNascimento.Location = new System.Drawing.Point(15, 115);
            this.monthCalendarNascimento.Name = "monthCalendarNascimento";
            this.monthCalendarNascimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morada:";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(15, 350);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(269, 22);
            this.textBoxMorada.TabIndex = 5;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(64, 510);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(161, 30);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adcionar Pessoa";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.ItemHeight = 16;
            this.listBoxPessoas.Location = new System.Drawing.Point(330, 38);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(526, 180);
            this.listBoxPessoas.TabIndex = 7;
            this.listBoxPessoas.SelectedIndexChanged += new System.EventHandler(this.listBoxPessoas_SelectedIndexChanged);
            // 
            // buttonPontuar
            // 
            this.buttonPontuar.Location = new System.Drawing.Point(330, 224);
            this.buttonPontuar.Name = "buttonPontuar";
            this.buttonPontuar.Size = new System.Drawing.Size(526, 28);
            this.buttonPontuar.TabIndex = 8;
            this.buttonPontuar.Text = "Pontuar";
            this.buttonPontuar.UseVisualStyleBackColor = true;
            this.buttonPontuar.Click += new System.EventHandler(this.buttonPontuar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disciplina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dificuldade:";
            // 
            // textBoxNumeroAluno
            // 
            this.textBoxNumeroAluno.Location = new System.Drawing.Point(99, 394);
            this.textBoxNumeroAluno.Name = "textBoxNumeroAluno";
            this.textBoxNumeroAluno.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumeroAluno.TabIndex = 13;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(99, 423);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(185, 22);
            this.textBoxCurso.TabIndex = 14;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(99, 454);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(185, 22);
            this.textBoxDisciplina.TabIndex = 15;
            // 
            // textBoxDificuldade
            // 
            this.textBoxDificuldade.Location = new System.Drawing.Point(99, 482);
            this.textBoxDificuldade.Name = "textBoxDificuldade";
            this.textBoxDificuldade.Size = new System.Drawing.Size(185, 22);
            this.textBoxDificuldade.TabIndex = 16;
            // 
            // buttonAluno
            // 
            this.buttonAluno.Location = new System.Drawing.Point(15, 546);
            this.buttonAluno.Name = "buttonAluno";
            this.buttonAluno.Size = new System.Drawing.Size(75, 59);
            this.buttonAluno.TabIndex = 17;
            this.buttonAluno.Text = "Adicionar Aluno";
            this.buttonAluno.UseVisualStyleBackColor = true;
            this.buttonAluno.Click += new System.EventHandler(this.buttonAluno_Click);
            // 
            // buttonAlunoEspecial
            // 
            this.buttonAlunoEspecial.Location = new System.Drawing.Point(108, 546);
            this.buttonAlunoEspecial.Name = "buttonAlunoEspecial";
            this.buttonAlunoEspecial.Size = new System.Drawing.Size(83, 59);
            this.buttonAlunoEspecial.TabIndex = 20;
            this.buttonAlunoEspecial.Text = "Adicionar Aluno Especial";
            this.buttonAlunoEspecial.UseVisualStyleBackColor = true;
            this.buttonAlunoEspecial.Click += new System.EventHandler(this.buttonAlunoEspecial_Click);
            // 
            // buttonProfessor
            // 
            this.buttonProfessor.Location = new System.Drawing.Point(209, 546);
            this.buttonProfessor.Name = "buttonProfessor";
            this.buttonProfessor.Size = new System.Drawing.Size(75, 59);
            this.buttonProfessor.TabIndex = 21;
            this.buttonProfessor.Text = "Adicionar Professor";
            this.buttonProfessor.UseVisualStyleBackColor = true;
            this.buttonProfessor.Click += new System.EventHandler(this.buttonProfessor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dados do Individuo:";
            // 
            // buttonCargo
            // 
            this.buttonCargo.Location = new System.Drawing.Point(330, 525);
            this.buttonCargo.Name = "buttonCargo";
            this.buttonCargo.Size = new System.Drawing.Size(526, 32);
            this.buttonCargo.TabIndex = 23;
            this.buttonCargo.Text = "Que tipo de pessoa sou?";
            this.buttonCargo.UseVisualStyleBackColor = true;
            this.buttonCargo.Click += new System.EventHandler(this.buttonCargo_Click);
            // 
            // textBoxDados
            // 
            this.textBoxDados.Location = new System.Drawing.Point(333, 299);
            this.textBoxDados.Multiline = true;
            this.textBoxDados.Name = "textBoxDados";
            this.textBoxDados.ReadOnly = true;
            this.textBoxDados.Size = new System.Drawing.Size(523, 202);
            this.textBoxDados.TabIndex = 24;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(333, 563);
            this.textBoxCargo.Multiline = true;
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.ReadOnly = true;
            this.textBoxCargo.Size = new System.Drawing.Size(523, 39);
            this.textBoxCargo.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 617);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.textBoxDados);
            this.Controls.Add(this.buttonCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonProfessor);
            this.Controls.Add(this.buttonAlunoEspecial);
            this.Controls.Add(this.buttonAluno);
            this.Controls.Add(this.textBoxDificuldade);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxNumeroAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPontuar);
            this.Controls.Add(this.listBoxPessoas);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendarNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Adicionar Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendarNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox listBoxPessoas;
        private System.Windows.Forms.Button buttonPontuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumeroAluno;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxDificuldade;
        private System.Windows.Forms.Button buttonAluno;
        private System.Windows.Forms.Button buttonAlunoEspecial;
        private System.Windows.Forms.Button buttonProfessor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCargo;
        private System.Windows.Forms.TextBox textBoxDados;
        private System.Windows.Forms.TextBox textBoxCargo;
    }
}

