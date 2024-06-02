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
    public partial class Form1 : Form
    {
        public List<Usuario> listaUsuario = new List<Usuario>();
        public List<Producto> listaProductos = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_dueno.Columns.Add("Nombre", "Nombre");
            dgv_dueno.Columns.Add("Apellido", "Apellido");
            dgv_dueno.Columns.Add("Telefono", "Teléfono");
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
                    string apellido = txt_apellido.Text;
                    string telefono = txt_telefono.Text;

                    // Crear una nueva instancia de Dueno
                    Usuario nuevoUsuario = new Usuario(nombre, apellido, telefono);

                    // Agregar la instancia a la lista
                    listaUsuario.Add(nuevoUsuario);

                    // Agregar los datos al DataGridView
                    dgv_dueno.Rows.Add(nombre, apellido, telefono);

                    MessageBox.Show("Ingresado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_estado.Text = "";
            txt_nombre.BackColor = Color.White;
            txt_apellido.BackColor = Color.White;
            txt_telefono.BackColor = Color.White;
            txt_estado.BackColor = Color.White;
        }

        private bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                txt_estado.Text = "Debes ingresar un nombre y un apellido válido";
                txt_estado.BackColor = Color.PaleVioletRed;
                return false;
            }
            // Verificar la longitud de los campos
            if (txt_nombre.Text.Length < 3 || txt_nombre.Text.Length > 25)
            {
                txt_estado.Text = "El nombre debe tener entre 3 y 25 caracteres";
                txt_estado.BackColor = Color.PaleVioletRed;
                return false;
            }

            if (txt_apellido.Text.Length < 3 || txt_apellido.Text.Length > 25)
            {
                txt_estado.Text = "El apellido debe tener entre 3 y 25 caracteres";
                txt_estado.BackColor = Color.PaleVioletRed;
                return false;
            }

            if (!int.TryParse(txt_telefono.Text, out int telefonoNumerico))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_telefono.Text.Length < 8 || txt_telefono.Text.Length > 10)
            {
                txt_estado.Text = "El telefono debe tener entre 7 y 10 caracteres";
                txt_estado.BackColor = Color.PaleVioletRed;
                return false;
            }

            // Si todas las validaciones son exitosas
            txt_estado.Text = "Campos válidos";
            txt_estado.BackColor = Color.LightGreen;
            txt_nombre.BackColor = Color.LightGreen;
            txt_apellido.BackColor = Color.LightGreen;
            txt_telefono.BackColor = Color.LightGreen;
            return true;
        }

        private void tsmi_productos_Click(object sender, EventArgs e)
        {
            mantenedorProducto manProducto = new mantenedorProducto(listaUsuario, listaProductos, this);
            manProducto.Show();
            this.Hide();

            manProducto.FormClosed += (s, args) => this.Show();
        }

        private void tsmi_buscador_Click(object sender, EventArgs e)
        {
        }

        private void tsmi_usuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
