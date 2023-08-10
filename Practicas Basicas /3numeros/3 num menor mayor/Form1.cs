namespace _3_num_menor_mayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numero1 = num1.Text;
            int nume1 = Int32.Parse(numero1); // transforma lo captado en el textbox en double, puede ser INT tambien.

            string numero2 = num2.Text;
             int nume2 = Int32.Parse(numero2);// se puede hacer tambien asi, double nume2 = Double.Parse(num2.Text); 

             string numero3 = num3.Text;
             int nume3 = Int32.Parse(numero3);


            // programa para evaluar 3 numeros y establecer cual es menor y cual es mayor 
            if (nume1 > nume2 && nume1 > nume3 && nume2 > nume3)
                {
                    MessageBox.Show("El mayor es: "+ nume1 + "El menor es: "+ nume3);

                }
                else if (nume1 > nume2 && nume1 > nume3 && nume3 > nume2)

                {
                    MessageBox.Show("El mayor es: " + nume1 + "El menor es: " + nume2);

                }
                else if (nume2 > nume1 && nume2 > nume3 && nume1 > nume3)
                {
                    MessageBox.Show("El mayor es: " + nume2 + "El menor es: " + nume3);

                }
                else if (nume2 > nume1 && nume2 > nume3 && nume3 > nume1)
                {
                    MessageBox.Show("El mayor es: " + nume1 + "El menor es: " + nume1);

                }
                else if (nume3 > nume2 && nume3 > nume1 && nume2 > nume1)
                {
                    MessageBox.Show("El mayor es: " + nume3 + "El menor es: " + nume1);

                }
                else if (nume3 > nume2 && nume3 > nume1 && nume1 > nume2)
                {
                    MessageBox.Show("El mayor es: " + nume3 + "El menor es: " + nume2);

                }
            




            //programa para sacar promedio de los tres numeros
            
                        int promedio = (nume1 + nume2 + nume3)/3;

                        MessageBox.Show("El promedio es: " + promedio);
            


            //programa para determinar si un numero es par o impar

            

            if (nume1 % 2 == 0 && nume2 % 2 == 0 && nume3 % 2 == 0)
            {
                MessageBox.Show("Los tres numeros son pares");

            }
           else if (nume1 % 2 != 0 && nume2 % 2 == 0 && nume3 % 2 == 0)
            {

                MessageBox.Show("El segundo y el tercer numero son pares");
            }
            else if (nume1 % 2 != 0 && nume2 % 2 != 0 && nume3 % 2 == 0)
            {

                MessageBox.Show("El tercer numero es par");
            }
            else if (nume1 % 2 != 0 && nume2 % 2 == 0 && nume3 % 2 != 0)
            {

                MessageBox.Show("El segundo numero es par");
            }
            else if (nume1 % 2 == 0 && nume2 % 2 != 0 && nume3 % 2 != 0)
            {

                MessageBox.Show("El primer numero es par");
            }
            else if (nume1 % 2 == 0 && nume2 % 2 != 0 && nume3 % 2 == 0)
            {

                MessageBox.Show("El primero y tercer numero son pares");
            }
            else {
                MessageBox.Show("Los numeros ingresados son impares");
            }
        }
    }
}