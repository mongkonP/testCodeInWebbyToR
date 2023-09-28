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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Userefforreferencetype.htm
    public partial  class frmUserefforreferencetype:Form
    {
        public frmUserefforreferencetype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserefforreferencetype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserefforreferencetype";
            this.Text = "frmUserefforreferencetype";
            this.Load += new System.EventHandler(this.frmUserefforreferencetype_Load);
            this.ResumeLayout(false);

        }

        private void frmUserefforreferencetype_Load(object sender, EventArgs e)
        {

        }
    }
}
