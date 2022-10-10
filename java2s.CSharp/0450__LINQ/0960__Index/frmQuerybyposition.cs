using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0960__Index
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Querybyposition.htm
    public partial  class frmQuerybyposition:Form
    {
        public frmQuerybyposition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQuerybyposition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQuerybyposition";
            this.Text = "frmQuerybyposition";
            this.Load += new System.EventHandler(this.frmQuerybyposition_Load);
            this.ResumeLayout(false);

        }

        private void frmQuerybyposition_Load(object sender, EventArgs e)
        {

        }
    }
}
