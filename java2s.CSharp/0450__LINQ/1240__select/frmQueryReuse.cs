using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/QueryReuse.htm
    public partial  class frmQueryReuse:Form
    {
        public frmQueryReuse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryReuse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryReuse";
            this.Text = "frmQueryReuse";
            this.Load += new System.EventHandler(this.frmQueryReuse_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryReuse_Load(object sender, EventArgs e)
        {

        }
    }
}
