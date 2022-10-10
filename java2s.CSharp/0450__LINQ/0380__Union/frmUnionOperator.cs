using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0380__Union
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UnionOperator.htm
    public partial  class frmUnionOperator:Form
    {
        public frmUnionOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnionOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnionOperator";
            this.Text = "frmUnionOperator";
            this.Load += new System.EventHandler(this.frmUnionOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmUnionOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
