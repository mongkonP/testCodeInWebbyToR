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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BrowserwithUrlentrybox.htm
    public partial  class frmBrowserwithUrlentrybox:Form
    {
        public frmBrowserwithUrlentrybox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBrowserwithUrlentrybox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBrowserwithUrlentrybox";
            this.Text = "frmBrowserwithUrlentrybox";
            this.Load += new System.EventHandler(this.frmBrowserwithUrlentrybox_Load);
            this.ResumeLayout(false);

        }

        private void frmBrowserwithUrlentrybox_Load(object sender, EventArgs e)
        {

        }
    }
}
