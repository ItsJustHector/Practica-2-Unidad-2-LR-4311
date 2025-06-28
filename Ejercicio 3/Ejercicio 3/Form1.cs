namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double ValorConvertido = 0;
            double Valor = double.Parse(txtValor.Text);
            if (cbDesde.SelectedItem.ToString() == "Centimetro")
            {
                switch(cbPara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        ValorConvertido = Valor;
                        break;
                    case "Metro":
                        ValorConvertido = Valor / 100;
                        break;
                    case "pulgada:54":
                        ValorConvertido = Valor / 2.54;
                        break;


                }
            }
            if (cbDesde.SelectedItem.ToString() == "Metro")
            {
                switch (cbPara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        ValorConvertido = Valor * 100;
                        break;
                    case "Metro":
                        ValorConvertido = Valor;
                        break;
                    case "pulgada:54":
                        ValorConvertido = Valor * 39.3701;
                        break;


                }
            }
            if (cbDesde.SelectedItem.ToString() == "Pulgada")
            {
                switch (cbPara.SelectedItem.ToString())
                {
                    case "Centimetro":
                        ValorConvertido = Valor * 2.54;
                        break;
                    case "Metro":
                        ValorConvertido = Valor / 39.3701;
                        break;
                    case "pulgada:54":
                        ValorConvertido = Valor;
                        break;


                }
            }
            MessageBox.Show($"El valor convertido es {ValorConvertido}");
        }
    }
}
