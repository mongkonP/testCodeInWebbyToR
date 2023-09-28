using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0020__IP_Address
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SetPortforanIPEndPoint.htm
    public partial  class frmSetPortforanIPEndPoint:Form
    {
        public frmSetPortforanIPEndPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetPortforanIPEndPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetPortforanIPEndPoint";
            this.Text = "frmSetPortforanIPEndPoint";
            this.Load += new System.EventHandler(this.frmSetPortforanIPEndPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmSetPortforanIPEndPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
