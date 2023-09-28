using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1540__DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LINQtoDataSet.htm
    public partial  class frmLINQtoDataSet:Form
    {
        public frmLINQtoDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLINQtoDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLINQtoDataSet";
            this.Text = "frmLINQtoDataSet";
            this.Load += new System.EventHandler(this.frmLINQtoDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmLINQtoDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
