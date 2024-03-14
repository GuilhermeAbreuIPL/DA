using System.Drawing.Text;

namespace ficha_complementar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_submeter_Click(object sender, EventArgs e)
        {
            string genero;
            if (radioButton_masculino.Checked ) {
                genero = "masculino";
            }
            else { genero = "feminino";};
            {
                label_resumo1.Text = "O " + textBox_nome.Text + " têm " + trackBar_idade.Value + " anos e mora " + textBox_morada.Text + 
                    "\n Este trabalha na empresa " + textBox_empresa.Text + " como " + comboBox_profissao.Text + " hà {anos} \n" +
                    "   Genero : " + genero +
                "\n     Filhos : " + domainUpDown_filhos.Text + 
                    "\n     CC: " + textBox_cc.Text ;
            }

        }
    }
}
