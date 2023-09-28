using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0860__NotifyIcon
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseTimertoupdateNotifyIcon.htm
    public partial  class frmUseTimertoupdateNotifyIcon:Form
    {
        public frmUseTimertoupdateNotifyIcon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTimertoupdateNotifyIcon
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTimertoupdateNotifyIcon";
            this.Text = "frmUseTimertoupdateNotifyIcon";
            this.Load += new System.EventHandler(this.frmUseTimertoupdateNotifyIcon_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTimertoupdateNotifyIcon_Load(object sender, EventArgs e)
        {

        }
    }
}
