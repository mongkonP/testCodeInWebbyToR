using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0160__OleDbDataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingMultiTabledDatasets.htm
    public partial  class frmUsingMultiTabledDatasets:Form
    {
        public frmUsingMultiTabledDatasets()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingMultiTabledDatasets
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingMultiTabledDatasets";
            this.Text = "frmUsingMultiTabledDatasets";
            this.Load += new System.EventHandler(this.frmUsingMultiTabledDatasets_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingMultiTabledDatasets_Load(object sender, EventArgs e)
        {

        }
    }
}
