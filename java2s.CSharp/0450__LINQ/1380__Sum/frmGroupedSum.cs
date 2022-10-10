using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1380__Sum
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupedSum.htm
    public partial  class frmGroupedSum:Form
    {
        public frmGroupedSum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupedSum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupedSum";
            this.Text = "frmGroupedSum";
            this.Load += new System.EventHandler(this.frmGroupedSum_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupedSum_Load(object sender, EventArgs e)
        {

        }
    }
}
