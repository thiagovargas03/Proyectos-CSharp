namespace NumeroPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcPrim_Click(object sender, EventArgs e)
        {
            double numero = 2; 
            string resultado = "";
            int contador = 0;

            while (contador < 100)
            {
                if (esNumeroPrimo(numero))
                {
                    resultado = resultado + "," + numero;
                    contador++;
                }
                numero++;
            }

            MessageBox.Show(resultado);

        }

        private bool esNumeroPrimo(double numero)
        {
            bool esPrimo = true;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;

                }
            }
            return esPrimo;

        }
    }
}