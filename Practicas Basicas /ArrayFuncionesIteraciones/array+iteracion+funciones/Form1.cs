namespace array_iteracion_funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lista = traerListado();
            mostrarListado(lista);



        }

        private List<int> traerListado()
        {
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(20);
            lista.Add(15);
            lista.Add(88);
            lista.Add(100);
            return lista;

        }

        private void mostrarListado (List<int> lista) // Las estructura de las funciones es [Modificadores]tipo_retorno nombre_funcion ([argumentos]){CODIGO}
        {

            for (int i = 0; i < lista.Count; i++) { 
            
                int numero = lista[i];
                MessageBox.Show("Los numeros son: " + numero);
            }


        }
    }
}