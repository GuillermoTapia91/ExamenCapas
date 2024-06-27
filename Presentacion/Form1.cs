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
    }
}