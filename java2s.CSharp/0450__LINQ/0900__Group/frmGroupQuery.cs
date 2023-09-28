using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0900__Group
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupQuery.htm
    public partial  class frmGroupQuery:Form
    {
        public frmGroupQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupQuery";
            this.Text = "frmGroupQuery";
            this.Load += new System.EventHandler(this.frmGroupQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
