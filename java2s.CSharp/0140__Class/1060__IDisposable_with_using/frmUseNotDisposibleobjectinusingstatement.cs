using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1060__IDisposable_with_using
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UseNotDisposibleobjectinusingstatement.htm
    public partial  class frmUseNotDisposibleobjectinusingstatement:Form
    {
        public frmUseNotDisposibleobjectinusingstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseNotDisposibleobjectinusingstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseNotDisposibleobjectinusingstatement";
            this.Text = "frmUseNotDisposibleobjectinusingstatement";
            this.Load += new System.EventHandler(this.frmUseNotDisposibleobjectinusingstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmUseNotDisposibleobjectinusingstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
