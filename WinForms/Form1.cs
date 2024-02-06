using Coder.DataAccess.Data;
using Project_Coderhouse.Entities;

namespace Coder.Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarUsuariosEnDataGridView();
            CargarListaDeProductosEnDataGridView();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarUsuariosEnDataGridView()
        {
            try
            {
                List<Usuario> listaUsuarios = UsuarioData.ListarUsuarios();

                dataGridView1.DataSource = listaUsuarios;

            }
            catch (Exception ex)
            {

            }
        }

        private void CargarListaDeProductosEnDataGridView()
        {
            try
            {
                List<Producto> productos = ProductoData.ListarProductos();

                dataGridView1.DataSource = productos;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
