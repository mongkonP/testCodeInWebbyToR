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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LinqToSql.htm
    public partial  class frmLinqToSql:Form
    {
        public frmLinqToSql()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinqToSql
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinqToSql";
            this.Text = "frmLinqToSql";
            this.Load += new System.EventHandler(this.frmLinqToSql_Load);
            this.ResumeLayout(false);

        }

        private void frmLinqToSql_Load(object sender, EventArgs e)
        {

        }
    }
}
