using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0370__HttpListener
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/HttpListenerDemo.htm
    public partial  class frmHttpListenerDemo:Form
    {
        public frmHttpListenerDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHttpListenerDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHttpListenerDemo";
            this.Text = "frmHttpListenerDemo";
            this.Load += new System.EventHandler(this.frmHttpListenerDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmHttpListenerDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
