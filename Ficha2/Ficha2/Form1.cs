namespace Ficha2
{
    public partial class Form1 : Form
    {
        private DateTime contadorTempo;
        private Boolean controladorStartStop;
        public Form1()
        {
            InitializeComponent();
            button_reset.Visible = false;
            contadorTempo = new DateTime(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHours.Text = DateTime.Now.ToLongTimeString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 1));
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
        }

        private void toolStripStatusLabelHours_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelContador_Click(object sender, EventArgs e)
        {

        }

        private void button_start_stop_Click(object sender, EventArgs e)
        {
            if (controladorStartStop == false)
            {
                timer1.Enabled = false;
                controladorStartStop = true;
                button_start_stop.Text = "START";
                button_reset.Visible = true;
            }
            else
            {
                button_reset.Visible = false;
                timer1.Enabled = true;
                controladorStartStop = false;
                button_start_stop.Text = "STOP";
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelContador.Text = ("00:00:00");
            contadorTempo = new DateTime(0);
        }
    }
}
