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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/BatchUpdateDemo.htm
    public partial  class frmBatchUpdateDemo:Form
    {
        public frmBatchUpdateDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBatchUpdateDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBatchUpdateDemo";
            this.Text = "frmBatchUpdateDemo";
            this.Load += new System.EventHandler(this.frmBatchUpdateDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmBatchUpdateDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
