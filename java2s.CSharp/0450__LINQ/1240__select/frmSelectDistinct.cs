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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SelectDistinct.htm
    public partial  class frmSelectDistinct:Form
    {
        public frmSelectDistinct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectDistinct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectDistinct";
            this.Text = "frmSelectDistinct";
            this.Load += new System.EventHandler(this.frmSelectDistinct_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectDistinct_Load(object sender, EventArgs e)
        {

        }
    }
}
