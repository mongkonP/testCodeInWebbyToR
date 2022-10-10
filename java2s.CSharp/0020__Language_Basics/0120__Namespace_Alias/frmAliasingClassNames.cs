using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0120__Namespace_Alias
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/AliasingClassNames.htm
    public partial  class frmAliasingClassNames:Form
    {
        public frmAliasingClassNames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAliasingClassNames
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAliasingClassNames";
            this.Text = "frmAliasingClassNames";
            this.Load += new System.EventHandler(this.frmAliasingClassNames_Load);
            this.ResumeLayout(false);

        }

        private void frmAliasingClassNames_Load(object sender, EventArgs e)
        {

        }
    }
}
