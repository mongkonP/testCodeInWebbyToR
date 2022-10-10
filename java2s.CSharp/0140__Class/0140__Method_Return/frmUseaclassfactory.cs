using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0140__Method_Return
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useaclassfactory.htm
    public partial  class frmUseaclassfactory:Form
    {
        public frmUseaclassfactory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseaclassfactory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseaclassfactory";
            this.Text = "frmUseaclassfactory";
            this.Load += new System.EventHandler(this.frmUseaclassfactory_Load);
            this.ResumeLayout(false);

        }

        private void frmUseaclassfactory_Load(object sender, EventArgs e)
        {

        }
    }
}
