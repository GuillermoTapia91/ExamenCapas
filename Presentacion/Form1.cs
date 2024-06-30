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
                txtDeleteRegion.Text = "";
                MessageBox.Show("Registro exitoso");
                dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Admin");
                throw;
            }

        }

        private void btnEditRegion_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.Actualizar(Convert.ToInt32(txtEditRegionID.Text), txtEditRegionName.Text);
                MessageBox.Show("Actualizaci�n exitosa");
                txtEditRegionID.Text = "";
                txtEditRegionName.Text = "";
                dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Admin");
                throw;
            }
            
        }

        private void btnDeleteRegion_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.Eliminar(Convert.ToInt32(txtDeleteRegion.Text));
                MessageBox.Show("Eliminaci�n exitosa");
                txtDeleteRegion.Text = "";
                dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Admin");
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
        }
    }
}