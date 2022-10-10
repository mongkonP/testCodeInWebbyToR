using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0320__lock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usethelockobject.htm
    public partial  class frmUsethelockobject:Form
    {
        public frmUsethelockobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethelockobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethelockobject";
            this.Text = "frmUsethelockobject";
            this.Load += new System.EventHandler(this.frmUsethelockobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethelockobject_Load(object sender, EventArgs e)
        {

        }
    }
}
