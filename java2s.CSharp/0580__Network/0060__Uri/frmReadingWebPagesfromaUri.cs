using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0060__Uri
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ReadingWebPagesfromaUri.htm
    public partial  class frmReadingWebPagesfromaUri:Form
    {
        public frmReadingWebPagesfromaUri()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingWebPagesfromaUri
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingWebPagesfromaUri";
            this.Text = "frmReadingWebPagesfromaUri";
            this.Load += new System.EventHandler(this.frmReadingWebPagesfromaUri_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingWebPagesfromaUri_Load(object sender, EventArgs e)
        {

        }
    }
}
