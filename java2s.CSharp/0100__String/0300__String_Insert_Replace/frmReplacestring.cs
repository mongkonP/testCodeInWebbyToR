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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Replacestring.htm
    public partial  class frmReplacestring:Form
    {
        public frmReplacestring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReplacestring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReplacestring";
            this.Text = "frmReplacestring";
            this.Load += new System.EventHandler(this.frmReplacestring_Load);
            this.ResumeLayout(false);

        }

        private void frmReplacestring_Load(object sender, EventArgs e)
        {

        }
    }
}
