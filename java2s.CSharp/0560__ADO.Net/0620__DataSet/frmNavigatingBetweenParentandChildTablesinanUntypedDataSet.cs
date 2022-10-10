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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/NavigatingBetweenParentandChildTablesinanUntypedDataSet.htm
    public partial  class frmNavigatingBetweenParentandChildTablesinanUntypedDataSet:Form
    {
        public frmNavigatingBetweenParentandChildTablesinanUntypedDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigatingBetweenParentandChildTablesinanUntypedDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigatingBetweenParentandChildTablesinanUntypedDataSet";
            this.Text = "frmNavigatingBetweenParentandChildTablesinanUntypedDataSet";
            this.Load += new System.EventHandler(this.frmNavigatingBetweenParentandChildTablesinanUntypedDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigatingBetweenParentandChildTablesinanUntypedDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
