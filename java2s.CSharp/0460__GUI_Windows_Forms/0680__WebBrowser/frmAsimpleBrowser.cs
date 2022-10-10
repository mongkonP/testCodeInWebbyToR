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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AsimpleBrowser.htm
    public partial  class frmAsimpleBrowser:Form
    {
        public frmAsimpleBrowser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpleBrowser
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpleBrowser";
            this.Text = "frmAsimpleBrowser";
            this.Load += new System.EventHandler(this.frmAsimpleBrowser_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpleBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
