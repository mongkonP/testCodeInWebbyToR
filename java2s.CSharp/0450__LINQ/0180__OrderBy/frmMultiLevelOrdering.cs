using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/MultiLevelOrdering.htm
    public partial  class frmMultiLevelOrdering:Form
    {
        public frmMultiLevelOrdering()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultiLevelOrdering
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultiLevelOrdering";
            this.Text = "frmMultiLevelOrdering";
            this.Load += new System.EventHandler(this.frmMultiLevelOrdering_Load);
            this.ResumeLayout(false);

        }

        private void frmMultiLevelOrdering_Load(object sender, EventArgs e)
        {

        }
    }
}
