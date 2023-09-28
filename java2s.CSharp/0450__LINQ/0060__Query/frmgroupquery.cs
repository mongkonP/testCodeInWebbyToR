using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0060__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/groupquery.htm
    public partial  class frmgroupquery:Form
    {
        public frmgroupquery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmgroupquery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmgroupquery";
            this.Text = "frmgroupquery";
            this.Load += new System.EventHandler(this.frmgroupquery_Load);
            this.ResumeLayout(false);

        }

        private void frmgroupquery_Load(object sender, EventArgs e)
        {

        }
    }
}
