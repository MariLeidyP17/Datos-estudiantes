using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Datos_Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {


            lbl_nombre.Text = txt_nombre.Text;
            lbl_matricula.Text = txt_matricula.Text;
            lbl_edad.Text = txt_edad.Text;
            lbl_carrera.Text = txt_carrera.Text;
            lbl_apellido.Text = txt_apellido.Text;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close ();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            txt_carrera.Clear();
        }
    }
}
