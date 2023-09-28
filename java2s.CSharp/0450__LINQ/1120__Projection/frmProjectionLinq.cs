using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1120__Projection
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ProjectionLinq.htm
    public partial  class frmProjectionLinq:Form
    {
        public frmProjectionLinq()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProjectionLinq
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProjectionLinq";
            this.Text = "frmProjectionLinq";
            this.Load += new System.EventHandler(this.frmProjectionLinq_Load);
            this.ResumeLayout(false);

        }

        private void frmProjectionLinq_Load(object sender, EventArgs e)
        {

        }
    }
}
