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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreatingaStronglyTypedDataSet.htm
    public partial  class frmCreatingaStronglyTypedDataSet:Form
    {
        public frmCreatingaStronglyTypedDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingaStronglyTypedDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingaStronglyTypedDataSet";
            this.Text = "frmCreatingaStronglyTypedDataSet";
            this.Load += new System.EventHandler(this.frmCreatingaStronglyTypedDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingaStronglyTypedDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
