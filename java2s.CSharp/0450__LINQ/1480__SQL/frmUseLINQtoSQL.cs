using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1480__SQL
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseLINQtoSQL.htm
    public partial  class frmUseLINQtoSQL:Form
    {
        public frmUseLINQtoSQL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLINQtoSQL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLINQtoSQL";
            this.Text = "frmUseLINQtoSQL";
            this.Load += new System.EventHandler(this.frmUseLINQtoSQL_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLINQtoSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
