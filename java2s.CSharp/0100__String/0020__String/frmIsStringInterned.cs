using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/IsStringInterned.htm
    public partial  class frmIsStringInterned:Form
    {
        public frmIsStringInterned()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsStringInterned
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsStringInterned";
            this.Text = "frmIsStringInterned";
            this.Load += new System.EventHandler(this.frmIsStringInterned_Load);
            this.ResumeLayout(false);

        }

        private void frmIsStringInterned_Load(object sender, EventArgs e)
        {

        }
    }
}
