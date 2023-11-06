using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVista.Mantenimientos
{
    public partial class frmClientes : Form
    {
        Controlador cn = new Controlador();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3001"; //codigo de apliacion asignado en el sistema
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtid, txtnombre, txttelefono, txtnit, txtEstado, txttipo };
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textbox = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());

        }
    }
}
