using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0471__Windows_Communication_Foundation.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0471__Windows-Communication-Foundation/WCFHelloWorldService.htm
    public partial  class frmWCFHelloWorldService:Form
    {
        public frmWCFHelloWorldService()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWCFHelloWorldService
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWCFHelloWorldService";
            this.Text = "frmWCFHelloWorldService";
            this.Load += new System.EventHandler(this.frmWCFHelloWorldService_Load);
            this.ResumeLayout(false);

        }

        private void frmWCFHelloWorldService_Load(object sender, EventArgs e)
        {

        }
    }
}
