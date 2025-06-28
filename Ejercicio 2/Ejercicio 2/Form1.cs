using System.DirectoryServices.ActiveDirectory;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                Minuto.Items.Add(i);
                Segundo.Items.Add(i);
                if (i < 24) (Hora.Items.Add(i);

                {
                    Hora.Items.Add(i);
                    Minuto.Items.Add(i);
                    Segundo.Items.Add((int)i);
                }
            }
            {
                int Hora;
                int Minuto;
                int Segundo;
            }

        private void Iniciar_Click(object sender, EventArgs e)
        {

            if (Iniciar.Text == "Iniciar")
            {
                Temporizador.Text = $"{Hora.SelectedItem}:{Minuto.SelectedItem}:{Segundo.SelectedItem}";
                Iniciar.Text = "Detener";
            }
            else
            {
                Temporizador.Text = "00:00:00";
                Iniciar.Text = "Iniciar";
                Segundo = 0;
                Minuto = 0;
                Hora = 0;
                Iniciar.Text = "Iniciar";
            }
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            if (Detener.Text == "Detener")
            {
                Temporizador.Text = "00:00:00";
                Iniciar.Text = "Iniciar";
                Segundo = 0;
                Minuto = 0;
                Hora = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string minuto = Minuto.SelectedItem.ToString();
            string segundo = Segundo.SelectedItem.ToString();
            string hora = Hora.SelectedItem.ToString();
            if hora == "23" && minuto == "59" && segundo == "59"
            {
                Temporizador.Text = "00:00:00";
                Hora.SelectedIndex = 0;
                Minuto.SelectedIndex = 0;
                Segundo.SelectedIndex = 0;
            }
            else if (segundo == "59")
            {
                segundo = "00";
                if (minuto == "59")
                {
                    minuto = "00";
                    hora = (int.Parse(hora) + 1).ToString();
                }
                else
                {
                    minuto = (int.Parse(minuto) + 1).ToString();
                }
            }
            else
            {
                segundo = (int.Parse(segundo) + 1).ToString();
            }

            if mporizador.Text == "00:00:00"
                {
                MessageBox.Show("El temporizador ha llegado a cero.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }