using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0100__Custom_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Formattingflags.htm
    public partial  class frmFormattingflags:Form
    {
        public frmFormattingflags()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormattingflags
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormattingflags";
            this.Text = "frmFormattingflags";
            this.Load += new System.EventHandler(this.frmFormattingflags_Load);
            this.ResumeLayout(false);

        }

        private void frmFormattingflags_Load(object sender, EventArgs e)
        {

        }
    }
}
