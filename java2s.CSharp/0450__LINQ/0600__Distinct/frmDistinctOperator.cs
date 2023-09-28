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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/DistinctOperator.htm
    public partial  class frmDistinctOperator:Form
    {
        public frmDistinctOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDistinctOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDistinctOperator";
            this.Text = "frmDistinctOperator";
            this.Load += new System.EventHandler(this.frmDistinctOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmDistinctOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
