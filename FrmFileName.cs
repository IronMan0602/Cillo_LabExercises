using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cillo05_LabExer
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text.Trim();
            this.Close();
        }
    }
}
