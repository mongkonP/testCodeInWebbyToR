using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0600__Distinct
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CreatetheDistinctquery.htm
    public partial  class frmCreatetheDistinctquery:Form
    {
        public frmCreatetheDistinctquery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatetheDistinctquery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatetheDistinctquery";
            this.Text = "frmCreatetheDistinctquery";
            this.Load += new System.EventHandler(this.frmCreatetheDistinctquery_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatetheDistinctquery_Load(object sender, EventArgs e)
        {

        }
    }
}
