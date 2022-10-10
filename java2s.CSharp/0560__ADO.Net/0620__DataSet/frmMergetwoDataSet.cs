using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0620__DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/MergetwoDataSet.htm
    public partial  class frmMergetwoDataSet:Form
    {
        public frmMergetwoDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMergetwoDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMergetwoDataSet";
            this.Text = "frmMergetwoDataSet";
            this.Load += new System.EventHandler(this.frmMergetwoDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmMergetwoDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
