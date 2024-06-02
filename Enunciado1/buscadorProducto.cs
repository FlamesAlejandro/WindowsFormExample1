using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado1
{
    public partial class buscadorProducto : Form
    {

        private List<Producto> listaProductos;
        private mantenedorProducto manProducto;

        public buscadorProducto(List<Producto> productos, mantenedorProducto mainForm)
        {
            InitializeComponent();
            listaProductos = productos;
            manProducto = mainForm; // Guardar la referencia al formulario principal
        }

        private void buscadorProducto_Load(object sender, EventArgs e)
        {
            dgv_buscador.Columns.Add("Nombre", "Nombre");
            dgv_buscador.Columns.Add("Marca", "Marca");
            dgv_buscador.Columns.Add("Precio", "Precio");
            dgv_buscador.Columns.Add("Usuario", "Usuario");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_buscador.Text))
            {
                MessageBox.Show("Debes ingresar un texto válido en el buscador.", "Error en el formulario");
            }
            string nombreBuscado = txt_buscador.Text.ToLower();
            var productosEncontrados = listaProductos.Where(p => p.Nombre.ToLower().Contains(nombreBuscado)).ToList();

            dgv_buscador.Rows.Clear();
            foreach (var producto in productosEncontrados)
            {
                dgv_buscador.Rows.Add(producto.Nombre, producto.Marca, producto.Precio, producto.Usuario.ToString());
            }

            if (productosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmi_productos_Click(object sender, EventArgs e)
        {
            this.Close();
            manProducto.Show();
        }
    }
}
