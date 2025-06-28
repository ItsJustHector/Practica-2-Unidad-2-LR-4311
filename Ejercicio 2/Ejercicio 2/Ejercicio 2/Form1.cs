namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
            contador = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
