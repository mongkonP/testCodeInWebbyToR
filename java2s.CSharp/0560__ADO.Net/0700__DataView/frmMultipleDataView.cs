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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/MultipleDataView.htm
    public partial  class frmMultipleDataView:Form
    {
        public frmMultipleDataView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultipleDataView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultipleDataView";
            this.Text = "frmMultipleDataView";
            this.Load += new System.EventHandler(this.frmMultipleDataView_Load);
            this.ResumeLayout(false);

        }

        private void frmMultipleDataView_Load(object sender, EventArgs e)
        {

        }
    }
}
