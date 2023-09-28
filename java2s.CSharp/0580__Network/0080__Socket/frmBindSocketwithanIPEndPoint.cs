using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0080__Socket
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/BindSocketwithanIPEndPoint.htm
    public partial  class frmBindSocketwithanIPEndPoint:Form
    {
        public frmBindSocketwithanIPEndPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindSocketwithanIPEndPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindSocketwithanIPEndPoint";
            this.Text = "frmBindSocketwithanIPEndPoint";
            this.Load += new System.EventHandler(this.frmBindSocketwithanIPEndPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmBindSocketwithanIPEndPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
