using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0320__SqlCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AsyncCommandObjectDemo.htm
    public partial  class frmAsyncCommandObjectDemo:Form
    {
        public frmAsyncCommandObjectDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsyncCommandObjectDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsyncCommandObjectDemo";
            this.Text = "frmAsyncCommandObjectDemo";
            this.Load += new System.EventHandler(this.frmAsyncCommandObjectDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmAsyncCommandObjectDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
