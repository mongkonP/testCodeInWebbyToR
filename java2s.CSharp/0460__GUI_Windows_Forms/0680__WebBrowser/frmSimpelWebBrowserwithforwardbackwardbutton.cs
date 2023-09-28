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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SimpelWebBrowserwithforwardbackwardbutton.htm
    public partial  class frmSimpelWebBrowserwithforwardbackwardbutton:Form
    {
        public frmSimpelWebBrowserwithforwardbackwardbutton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpelWebBrowserwithforwardbackwardbutton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpelWebBrowserwithforwardbackwardbutton";
            this.Text = "frmSimpelWebBrowserwithforwardbackwardbutton";
            this.Load += new System.EventHandler(this.frmSimpelWebBrowserwithforwardbackwardbutton_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpelWebBrowserwithforwardbackwardbutton_Load(object sender, EventArgs e)
        {

        }
    }
}
