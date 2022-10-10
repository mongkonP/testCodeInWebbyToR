using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0120__String_SubString
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/UseSubstring.htm
    public partial  class frmUseSubstring:Form
    {
        public frmUseSubstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSubstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSubstring";
            this.Text = "frmUseSubstring";
            this.Load += new System.EventHandler(this.frmUseSubstring_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSubstring_Load(object sender, EventArgs e)
        {

        }
    }
}
