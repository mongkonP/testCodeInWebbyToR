using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0700__DataView
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoopthroughDataRowViewinDataView.htm
    public partial  class frmLoopthroughDataRowViewinDataView:Form
    {
        public frmLoopthroughDataRowViewinDataView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoopthroughDataRowViewinDataView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoopthroughDataRowViewinDataView";
            this.Text = "frmLoopthroughDataRowViewinDataView";
            this.Load += new System.EventHandler(this.frmLoopthroughDataRowViewinDataView_Load);
            this.ResumeLayout(false);

        }

        private void frmLoopthroughDataRowViewinDataView_Load(object sender, EventArgs e)
        {

        }
    }
}
