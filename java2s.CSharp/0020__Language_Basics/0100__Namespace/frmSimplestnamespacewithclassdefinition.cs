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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Simplestnamespacewithclassdefinition.htm
    public partial  class frmSimplestnamespacewithclassdefinition:Form
    {
        public frmSimplestnamespacewithclassdefinition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplestnamespacewithclassdefinition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplestnamespacewithclassdefinition";
            this.Text = "frmSimplestnamespacewithclassdefinition";
            this.Load += new System.EventHandler(this.frmSimplestnamespacewithclassdefinition_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplestnamespacewithclassdefinition_Load(object sender, EventArgs e)
        {

        }
    }
}
