using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0060__Object_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useinterfaceasreference.htm
    public partial  class frmUseinterfaceasreference:Form
    {
        public frmUseinterfaceasreference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseinterfaceasreference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseinterfaceasreference";
            this.Text = "frmUseinterfaceasreference";
            this.Load += new System.EventHandler(this.frmUseinterfaceasreference_Load);
            this.ResumeLayout(false);

        }

        private void frmUseinterfaceasreference_Load(object sender, EventArgs e)
        {

        }
    }
}
