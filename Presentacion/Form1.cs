using Negocio;
using System.DirectoryServices.ActiveDirectory;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRegion negocio = new NRegion();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnListarRegion_Click(object sender, EventArgs e)
        {
            dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertRegion_Click(object sender, EventArgs e)
        {
            try
            {
                //Registrat Rol, se comunica con la capa negocio
                
                negocio.Insertar(txtRegionName.Text);
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Admin");
                throw;
            }

        }
    }
}