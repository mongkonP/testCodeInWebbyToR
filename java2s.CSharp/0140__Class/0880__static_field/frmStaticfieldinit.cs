using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Staticfieldinit.htm
    public partial  class frmStaticfieldinit:Form
    {
        public frmStaticfieldinit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticfieldinit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticfieldinit";
            this.Text = "frmStaticfieldinit";
            this.Load += new System.EventHandler(this.frmStaticfieldinit_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticfieldinit_Load(object sender, EventArgs e)
        {

        }
    }
}
