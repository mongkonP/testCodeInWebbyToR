using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0620__ElementAt
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UsingElementAt.htm
    public partial  class frmUsingElementAt:Form
    {
        public frmUsingElementAt()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingElementAt
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingElementAt";
            this.Text = "frmUsingElementAt";
            this.Load += new System.EventHandler(this.frmUsingElementAt_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingElementAt_Load(object sender, EventArgs e)
        {

        }
    }
}
