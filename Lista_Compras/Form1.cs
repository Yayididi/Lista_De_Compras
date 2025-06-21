using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_Compras;
using System.Windows.Forms;



namespace Lista_Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var service = new CompraService();
            var lista = service.ObtenerCompras();
            dgvCompras.DataSource = lista;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrarbtn_Click(object sender, EventArgs e)
        {
            var articulo = new Articulo
            {
                Nombre = txtArticulo.Text,
                CantidadEstimada = int.Parse(CantEsttxt.Text),
                PrecioEstimado = decimal.Parse(PrecioEsttxt.Text),
                Encontrado = chkEncontrado.Checked,
                PrecioReal = decimal.Parse(txtPrecioReal.Text)


            };

            CompraService service = new CompraService();
            service.AgregarCompra(articulo);

            MessageBox.Show("¡Artículo registrado!");
            CargarDatos();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCompras.CurrentRow.Cells["Id"].Value);

                var articulo = new Articulo
                {
                    Id = id,
                    CantidadEstimada = int.Parse(CantEsttxt.Text),
                    PrecioReal = decimal.Parse(txtPrecioReal.Text),
                    Encontrado = chkEncontrado.Checked
                };

                var service = new CompraService();
                service.ActualizarArticulo(articulo);

                MessageBox.Show("¡Artículo actualizado!");
                CargarDatos();
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
