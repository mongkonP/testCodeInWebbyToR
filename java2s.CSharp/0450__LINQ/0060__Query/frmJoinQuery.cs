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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/JoinQuery.htm
    public partial  class frmJoinQuery:Form
    {
        public frmJoinQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmJoinQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmJoinQuery";
            this.Text = "frmJoinQuery";
            this.Load += new System.EventHandler(this.frmJoinQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmJoinQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
