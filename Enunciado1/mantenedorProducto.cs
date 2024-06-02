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
    public partial class mantenedorProducto : Form
    {
        
        private List<Producto> listaProductos;
        private Form1 form1;

        public mantenedorProducto(List<Usuario> usuario, List<Producto> producto, Form1 mainForm)
        {
            InitializeComponent();
            listaProductos = producto;
            cb_usuario.DataSource = usuario;
            cb_usuario.DisplayMember = "ToString"; // Mostrar el nombre completo en el ComboBox
            form1 = mainForm; // Guardar la referencia al formulario principal
        }

        private void mantenedorProducto_Load(object sender, EventArgs e)
        {
            dgv_producto.Columns.Add("Nombre", "Nombre");
            dgv_producto.Columns.Add("Marca", "Marca");
            dgv_producto.Columns.Add("Precio", "Precio");
            dgv_producto.Columns.Add("Usuario", "Usuario");
        }

        private void tsmi_usuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void tsmi_buscador_Click(object sender, EventArgs e)
        {
            buscadorProducto busProducto = new buscadorProducto(listaProductos, this);
            busProducto.Show();
            this.Hide();

            busProducto.FormClosed += (s, args) => this.Show();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                if (verificarCampos())
                {
                    // Traer el texto del formulario
                    string nombre = txt_nombre.Text;
                    string marca = txt_marca.Text;
                    decimal precio = nud_precio.Value;
                    Usuario usuario = (Usuario)cb_usuario.SelectedItem;

                    // Agregar los datos a la lista de productos
                    Producto nuevoProducto = new Producto(nombre, marca, precio, usuario);
                    listaProductos.Add(nuevoProducto);

                    // Agregar los datos al DataGridView
                    dgv_producto.Rows.Add(nuevoProducto.Nombre, nuevoProducto.Marca, nuevoProducto.Precio, nuevoProducto.Usuario.ToString());

                    MessageBox.Show("El registro se ha ingresado correctamente.", "Registro completado");

                    // Limpiar los TextBox
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Verificar campos.", "Error en el ingreso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_marca.Clear();
            nud_precio.Value = nud_precio.Minimum;
            cb_usuario.SelectedIndex = -1;
            txt_nombre.BackColor = Color.White;
            txt_marca.BackColor = Color.White;
            nud_precio.BackColor = Color.White;
            cb_usuario.BackColor = Color.White;
        }

        private bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_marca.Text))
            {
                MessageBox.Show("Debes ingresar un nombre y un marca válido.", "Error en el formulario");
                txt_nombre.BackColor = Color.PaleVioletRed;
                return false;
            }

            // Verificar la longitud de los campos
            if (txt_nombre.Text.Length < 3 || txt_nombre.Text.Length > 25)
            {
                MessageBox.Show("El nombre debe tener entre 3 y 25 caracteres.", "Error en el nombre");
                txt_nombre.BackColor = Color.PaleVioletRed;
                return false;
            }
            txt_nombre.BackColor = Color.Green;

            if (txt_marca.Text.Length < 3 || txt_marca.Text.Length > 25)
            {
                MessageBox.Show("El marca debe tener entre 3 y 25 caracteres.", "Error en la marca");
                txt_marca.BackColor = Color.PaleVioletRed;
                return false;
            }
            txt_marca.BackColor = Color.Green;

            if (nud_precio.Value <= 0)
            {
                MessageBox.Show("Por favor, debe ingresar un precio superior a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_precio.BackColor = Color.PaleVioletRed;
                return false;
            }
            nud_precio.BackColor = Color.Green;

            int selectedIndex = cb_usuario.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Error en el selector de usuario");
                cb_usuario.BackColor = Color.PaleVioletRed;
                return false;
            }
            cb_usuario.BackColor = Color.Green;

            return true;
        }
    }
}
