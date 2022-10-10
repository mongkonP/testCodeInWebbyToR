using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0140__Join
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/JoinOperator.htm
    public partial  class frmJoinOperator:Form
    {
        public frmJoinOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmJoinOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmJoinOperator";
            this.Text = "frmJoinOperator";
            this.Load += new System.EventHandler(this.frmJoinOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmJoinOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
