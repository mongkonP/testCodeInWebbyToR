using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0300__String_Insert_Replace
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Replacesubstring.htm
    public partial  class frmReplacesubstring:Form
    {
        public frmReplacesubstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReplacesubstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReplacesubstring";
            this.Text = "frmReplacesubstring";
            this.Load += new System.EventHandler(this.frmReplacesubstring_Load);
            this.ResumeLayout(false);

        }

        private void frmReplacesubstring_Load(object sender, EventArgs e)
        {

        }
    }
}
