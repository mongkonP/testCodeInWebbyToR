using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0620__Warning
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Disablecompilerwarning.htm
    public partial  class frmDisablecompilerwarning:Form
    {
        public frmDisablecompilerwarning()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisablecompilerwarning
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisablecompilerwarning";
            this.Text = "frmDisablecompilerwarning";
            this.Load += new System.EventHandler(this.frmDisablecompilerwarning_Load);
            this.ResumeLayout(false);

        }

        private void frmDisablecompilerwarning_Load(object sender, EventArgs e)
        {

        }
    }
}
