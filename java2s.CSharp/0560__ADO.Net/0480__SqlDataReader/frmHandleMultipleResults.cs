using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0480__SqlDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/HandleMultipleResults.htm
    public partial  class frmHandleMultipleResults:Form
    {
        public frmHandleMultipleResults()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandleMultipleResults
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandleMultipleResults";
            this.Text = "frmHandleMultipleResults";
            this.Load += new System.EventHandler(this.frmHandleMultipleResults_Load);
            this.ResumeLayout(false);

        }

        private void frmHandleMultipleResults_Load(object sender, EventArgs e)
        {

        }
    }
}
