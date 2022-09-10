using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCreatorAndTestor
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void butGMP_Click(object sender, EventArgs e)
        {
            Generateur frmGMP = new Generateur();
            frmGMP.Show();
        }

        private void butGestionnaire_Click(object sender, EventArgs e)
        {
            Gestionnaire frmGest = new Gestionnaire();
            frmGest.Show();
        }
    }
}
