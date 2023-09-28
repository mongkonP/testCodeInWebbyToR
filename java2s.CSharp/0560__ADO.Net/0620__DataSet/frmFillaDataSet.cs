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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/FillaDataSet.htm
    public partial  class frmFillaDataSet:Form
    {
        public frmFillaDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillaDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillaDataSet";
            this.Text = "frmFillaDataSet";
            this.Load += new System.EventHandler(this.frmFillaDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmFillaDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
