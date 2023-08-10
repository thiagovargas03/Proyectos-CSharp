namespace IndiceGrasaCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnEvalIMC_Click_1(object sender, EventArgs e)
        {
                string textoPeso = txtPeso.Text;
                double peso = Double.Parse(textoPeso); // peso en KG

                string textoAltura = txtAltura.Text;
                double altura = Double.Parse(textoAltura); // altura en metros

                double IMC = peso / (altura * altura);

                MessageBox.Show("El IMC es: " + IMC);

            }
        }
    }
