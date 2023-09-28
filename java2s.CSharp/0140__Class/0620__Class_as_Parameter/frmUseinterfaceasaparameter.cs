using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0620__Class_as_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useinterfaceasaparameter.htm
    public partial  class frmUseinterfaceasaparameter:Form
    {
        public frmUseinterfaceasaparameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseinterfaceasaparameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseinterfaceasaparameter";
            this.Text = "frmUseinterfaceasaparameter";
            this.Load += new System.EventHandler(this.frmUseinterfaceasaparameter_Load);
            this.ResumeLayout(false);

        }

        private void frmUseinterfaceasaparameter_Load(object sender, EventArgs e)
        {

        }
    }
}
