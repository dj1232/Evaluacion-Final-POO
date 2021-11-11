using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_de_Empleados
{
    public partial class frm_registro : Form
    {
        public frm_registro()
        {
            InitializeComponent();
        }

        private Empleado[] empleados = new Empleado[10];
        private int edit_indice = -1;

        private bool validar()
        {
            bool validado = true;
            if (txt_nombre.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
                errorProvider1.SetError(txt_nombre, "Ingresar nombre"); 
            
            }       
           
            if (txt_apellido.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txt_apellido, "Ingrese apellido");
            }
            return validado;
        }
    }
}
