using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Demonstratetheeffectsofpointerarithmethic.htm
    public partial  class frmDemonstratetheeffectsofpointerarithmethic:Form
    {
        public frmDemonstratetheeffectsofpointerarithmethic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheeffectsofpointerarithmethic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheeffectsofpointerarithmethic";
            this.Text = "frmDemonstratetheeffectsofpointerarithmethic";
            this.Load += new System.EventHandler(this.frmDemonstratetheeffectsofpointerarithmethic_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheeffectsofpointerarithmethic_Load(object sender, EventArgs e)
        {

        }
    }
}
