namespace GestionClientesSQL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void GestionarClientes_Click(object sender , EventArgs e)
        {

            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();
        }
    }
}