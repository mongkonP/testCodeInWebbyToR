using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0100__PermissionSet
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Imperativesecuritydemands.htm
    public partial  class frmImperativesecuritydemands:Form
    {
        public frmImperativesecuritydemands()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImperativesecuritydemands
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImperativesecuritydemands";
            this.Text = "frmImperativesecuritydemands";
            this.Load += new System.EventHandler(this.frmImperativesecuritydemands_Load);
            this.ResumeLayout(false);

        }

        private void frmImperativesecuritydemands_Load(object sender, EventArgs e)
        {

        }
    }
}
