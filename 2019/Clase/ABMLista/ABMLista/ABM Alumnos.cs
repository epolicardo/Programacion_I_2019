using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMLista.Clases;

namespace ABMLista
{
    public partial class ABM_Alumnos : Form
    {
        #region Propiedades
        
        Lista listadeAlumnos = new Lista();
        Alumnos alumnos = new Alumnos();
        
        #endregion



        public ABM_Alumnos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listadeAlumnos.Agregar(txtAlumno.Text))
            {
                lblListaAlumnos.Text = listadeAlumnos.MostrarLista(0);

                lblNotas.Text = listadeAlumnos.MostrarLista(1);
            }
            
        }
    }
}
