using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0080__Nested_Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Anuntidynestedquery.htm
    public partial  class frmAnuntidynestedquery:Form
    {
        public frmAnuntidynestedquery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnuntidynestedquery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnuntidynestedquery";
            this.Text = "frmAnuntidynestedquery";
            this.Load += new System.EventHandler(this.frmAnuntidynestedquery_Load);
            this.ResumeLayout(false);

        }

        private void frmAnuntidynestedquery_Load(object sender, EventArgs e)
        {

        }
    }
}
