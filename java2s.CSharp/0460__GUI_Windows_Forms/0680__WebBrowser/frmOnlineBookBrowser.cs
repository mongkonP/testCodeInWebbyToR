using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0680__WebBrowser
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OnlineBookBrowser.htm
    public partial  class frmOnlineBookBrowser:Form
    {
        public frmOnlineBookBrowser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOnlineBookBrowser
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOnlineBookBrowser";
            this.Text = "frmOnlineBookBrowser";
            this.Load += new System.EventHandler(this.frmOnlineBookBrowser_Load);
            this.ResumeLayout(false);

        }

        private void frmOnlineBookBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
