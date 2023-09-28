using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0140__Join
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CartesianJoindemo.htm
    public partial  class frmCartesianJoindemo:Form
    {
        public frmCartesianJoindemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCartesianJoindemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCartesianJoindemo";
            this.Text = "frmCartesianJoindemo";
            this.Load += new System.EventHandler(this.frmCartesianJoindemo_Load);
            this.ResumeLayout(false);

        }

        private void frmCartesianJoindemo_Load(object sender, EventArgs e)
        {

        }
    }
}
