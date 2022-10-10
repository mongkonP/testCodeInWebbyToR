using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0200__ref
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Useoutforreferencetype.htm
    public partial  class frmUseoutforreferencetype:Form
    {
        public frmUseoutforreferencetype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseoutforreferencetype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseoutforreferencetype";
            this.Text = "frmUseoutforreferencetype";
            this.Load += new System.EventHandler(this.frmUseoutforreferencetype_Load);
            this.ResumeLayout(false);

        }

        private void frmUseoutforreferencetype_Load(object sender, EventArgs e)
        {

        }
    }
}
