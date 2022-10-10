using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0380__WebRequest
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ReadingWebPageAsHTML.htm
    public partial  class frmReadingWebPageAsHTML:Form
    {
        public frmReadingWebPageAsHTML()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingWebPageAsHTML
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingWebPageAsHTML";
            this.Text = "frmReadingWebPageAsHTML";
            this.Load += new System.EventHandler(this.frmReadingWebPageAsHTML_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingWebPageAsHTML_Load(object sender, EventArgs e)
        {

        }
    }
}
