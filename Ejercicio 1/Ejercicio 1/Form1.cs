namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int numero = int.Parse(textBox1.Text);
                int n = numero;""
                if (n < 0)
                {
                    MessageBox.Show("Por favor, ingrese un número entero positivo.");
                    return;
                }
                for (int i = 0; i <= n; i++)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            if (int.TryParse(textBox1.Text, out int n)) { listBox1.Items.Add(n);
             
                    {
                        for (int i = 1; i <= n; i++)
                        {
                        int resultado = *i * n;
                        listBox1.Items.Add($"{n} x {i} = {resultado}");
                        }
                    }
                
        }
    }
}
