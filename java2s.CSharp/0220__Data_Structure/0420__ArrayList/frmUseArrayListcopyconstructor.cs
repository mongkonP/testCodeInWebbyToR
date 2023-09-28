using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UseArrayListcopyconstructor.htm
    public partial  class frmUseArrayListcopyconstructor:Form
    {
        public frmUseArrayListcopyconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseArrayListcopyconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseArrayListcopyconstructor";
            this.Text = "frmUseArrayListcopyconstructor";
            this.Load += new System.EventHandler(this.frmUseArrayListcopyconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmUseArrayListcopyconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
