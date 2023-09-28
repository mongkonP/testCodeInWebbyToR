using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Fullqualifyname.htm
    public partial  class frmFullqualifyname:Form
    {
        public frmFullqualifyname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFullqualifyname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFullqualifyname";
            this.Text = "frmFullqualifyname";
            this.Load += new System.EventHandler(this.frmFullqualifyname_Load);
            this.ResumeLayout(false);

        }

        private void frmFullqualifyname_Load(object sender, EventArgs e)
        {

        }
    }
}
