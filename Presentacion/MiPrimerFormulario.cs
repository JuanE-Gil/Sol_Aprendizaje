using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        // Inicio de mis variables
        int NestadoGuarda = 0;

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 1; // Nuevo Registro
            lst_mantenimiento.Enabled = false;

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;

            grb_botones_principales.Enabled = false;
            txt_codigo.Enabled = true;

            txt_codigo.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_botones_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string Registro;
            Registro = txt_codigo.Text.Trim() + " | " + txt_descripcion.Text.Trim();

            if (NestadoGuarda == 1) // Nuevo Registro
            {
                lst_mantenimiento.Items.Add(Registro);
            }
            else // Actualizar Registro
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;

                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);
            }

            MessageBox.Show("Datos Guardados");

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_botones_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

            MessageBox.Show("Elemento Eliminado");

        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int longitudTexto;

            TextoSeleccionado = lst_mantenimiento.SelectedItem.ToString().Trim();
            longitudTexto = TextoSeleccionado.Length;

            txt_codigo.Text = TextoSeleccionado.Substring(0, 3);
            txt_descripcion.Text = TextoSeleccionado.Substring(6, longitudTexto - 6);


        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2;
            lst_mantenimiento.Enabled = false;

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = false;
            grb_botones_principales.Enabled = false;
            txt_codigo.Focus();
        }
    }
}
