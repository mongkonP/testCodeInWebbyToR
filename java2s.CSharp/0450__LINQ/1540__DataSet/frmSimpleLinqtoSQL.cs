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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SimpleLinqtoSQL.htm
    public partial  class frmSimpleLinqtoSQL:Form
    {
        public frmSimpleLinqtoSQL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleLinqtoSQL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleLinqtoSQL";
            this.Text = "frmSimpleLinqtoSQL";
            this.Load += new System.EventHandler(this.frmSimpleLinqtoSQL_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleLinqtoSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
