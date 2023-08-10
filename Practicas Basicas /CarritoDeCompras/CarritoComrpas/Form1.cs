namespace CarritoComrpas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProductos.Items.Add("Pantalon");
            cmbProductos.Items.Add("Camisa");
            cmbProductos.Items.Add("Zapatillas");

        }

        private void agrProd_Click(object sender, EventArgs e)
        {
            string productoSeleccionado= cmbProductos.SelectedItem.ToString();
            listProductos.Items.Add(productoSeleccionado);
        }

        private void calcPrecio_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;

            int totalProductosCargados = listProductos.Items.Count;

            string codPromo = txtPromo.Text;

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listProductos.Items[i].ToString();
                if(productoElegido == "Pantalon")
                {
                    precioFinal += 20;

                }
                else if (productoElegido == "Camisa")
                {
                    precioFinal += 35;

                }
                else if (productoElegido == "Zapatillas")
                {
                    precioFinal += 24;

                }
              
            }

            if (codPromo == "NAVIDAD")
            {
                double precioDesc = (precioFinal*10) / 100;
                precioFinal = precioFinal - precioDesc;
            }
            MessageBox.Show("El precio final es de: " + precioFinal);
        }
    }
}