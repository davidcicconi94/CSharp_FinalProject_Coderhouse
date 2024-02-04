using Coder.DataAccess.Data;
using Project_Coderhouse.Entities;

namespace Coder.Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;

            Usuario usuario = UsuarioData.ObtenerUsuario(idUsuario);

            if(usuario != null) 
            {
                listBox1.Items.Add(usuario.Nombre);   
            } else
            {
                listBox1.Text = $"Usuario con ID {idUsuario} no encontrado.";
            }
        }
    }
}
