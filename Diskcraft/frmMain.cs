using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Diskcraft
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            // Set the active control to a button that does nothing. 
            this.ActiveControl = btnControl;

            // Despawn the control elements group box.
            gbElements.Visible = false;

            // Get the executing assembly.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Get the project name.
            string projectName = assembly.GetName().Name;

            // Get the version.
            string version = assembly.GetName().Version.ToString();

            // Set the main form text to the project name and version. 
            this.Text = projectName + " " + version;
    
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {

        }

        private void btnScripts_Click(object sender, EventArgs e)
        {

        }

        private void btnOS_Click(object sender, EventArgs e)
        {

        }
    }
}
