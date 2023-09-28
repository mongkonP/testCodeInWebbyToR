using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0060__Comments
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Illustratestheuseofcomments.htm
    public partial  class frmIllustratestheuseofcomments:Form
    {
        public frmIllustratestheuseofcomments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustratestheuseofcomments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustratestheuseofcomments";
            this.Text = "frmIllustratestheuseofcomments";
            this.Load += new System.EventHandler(this.frmIllustratestheuseofcomments_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustratestheuseofcomments_Load(object sender, EventArgs e)
        {

        }
    }
}
