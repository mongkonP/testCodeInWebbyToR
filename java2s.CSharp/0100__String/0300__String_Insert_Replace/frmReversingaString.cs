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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/ReversingaString.htm
    public partial  class frmReversingaString:Form
    {
        public frmReversingaString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReversingaString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReversingaString";
            this.Text = "frmReversingaString";
            this.Load += new System.EventHandler(this.frmReversingaString_Load);
            this.ResumeLayout(false);

        }

        private void frmReversingaString_Load(object sender, EventArgs e)
        {

        }
    }
}
