using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionCitasMedicas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optMedic_Click(object sender, EventArgs e)
        {
            FrmMedicos medicos = new FrmMedicos();
            medicos.Show();
        }

        private void optPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes pacientes = new FrmPacientes();
            pacientes.Show();
        }

        private void optCitas_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();
            citas.Show();
        }
    }
}
