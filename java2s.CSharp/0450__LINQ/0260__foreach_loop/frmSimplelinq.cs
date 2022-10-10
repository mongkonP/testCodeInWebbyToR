using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0260__foreach_loop
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Simplelinq.htm
    public partial  class frmSimplelinq:Form
    {
        public frmSimplelinq()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplelinq
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplelinq";
            this.Text = "frmSimplelinq";
            this.Load += new System.EventHandler(this.frmSimplelinq_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplelinq_Load(object sender, EventArgs e)
        {

        }
    }
}
