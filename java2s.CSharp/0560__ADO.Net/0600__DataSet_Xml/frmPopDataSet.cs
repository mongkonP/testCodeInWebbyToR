using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0600__DataSet_Xml
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PopDataSet.htm
    public partial  class frmPopDataSet:Form
    {
        public frmPopDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPopDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPopDataSet";
            this.Text = "frmPopDataSet";
            this.Load += new System.EventHandler(this.frmPopDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmPopDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
