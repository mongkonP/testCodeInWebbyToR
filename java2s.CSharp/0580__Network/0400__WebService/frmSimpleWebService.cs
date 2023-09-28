using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0400__WebService
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleWebService.htm
    public partial  class frmSimpleWebService:Form
    {
        public frmSimpleWebService()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleWebService
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleWebService";
            this.Text = "frmSimpleWebService";
            this.Load += new System.EventHandler(this.frmSimpleWebService_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleWebService_Load(object sender, EventArgs e)
        {

        }
    }
}
