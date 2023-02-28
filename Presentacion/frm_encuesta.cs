using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_encuesta : Form
    {
        public frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if (chk_vfp.Checked)
            {
                Resultado += chk_vfp.Text + " ";
            }

            if (chk_csharp.Checked)
            {
                Resultado += chk_csharp.Text + " ";
            }

            if (chk_vbnet.Checked)
            {
                Resultado += chk_vbnet.Text + " ";
            }

            if (chk_java.Checked)
            {
                Resultado += chk_java.Text;
            }

            // Evaluando proceso de selección del radiobutton

            if (rdb_presencial.Checked)
            {
                Resultado += " :::: " + rdb_presencial.Text + " :::: ";
            }
            else
            {
                Resultado += " :::: " + rdb_virtual.Text + " :::: ";
            }

            txt_resultado.Text = Resultado;
        }
    }
}
