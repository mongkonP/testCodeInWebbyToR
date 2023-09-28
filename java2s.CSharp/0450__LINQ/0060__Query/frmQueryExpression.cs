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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/QueryExpression.htm
    public partial  class frmQueryExpression:Form
    {
        public frmQueryExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryExpression";
            this.Text = "frmQueryExpression";
            this.Load += new System.EventHandler(this.frmQueryExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
