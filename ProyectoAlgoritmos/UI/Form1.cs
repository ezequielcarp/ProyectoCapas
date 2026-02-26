using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshPantalla();
            txtId.Enabled = false; 
        }

        public void refreshPantalla()
        {
            dataGridView1.DataSource = PersonaBLL.PresentarRegistro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = txtNombre.Text;
            persona.edad = Convert.ToInt32(txtEdad.Text);
            persona.celular = txtCelular.Text;



            if (string.IsNullOrEmpty(txtId.Text))
            {
                int result = PersonaBLL.AgregarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al guardar");
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            else
            {
                persona.id = Convert.ToInt32(txtId.Text);

                int result = PersonaBLL.ModificarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al modificar");
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }

            refreshPantalla();
        }
            

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtEdad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["edad"].Value);
            txtCelular.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["celular"].Value);
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCelular.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                int resultado = PersonaBLL.EliminarPersona(id);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Exito al eliminar");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar");                   
                    }
            }
            refreshPantalla();
        }
    }
}
