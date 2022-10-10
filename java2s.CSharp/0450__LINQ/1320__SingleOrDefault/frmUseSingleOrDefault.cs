using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1320__SingleOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseSingleOrDefault.htm
    public partial  class frmUseSingleOrDefault:Form
    {
        public frmUseSingleOrDefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSingleOrDefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSingleOrDefault";
            this.Text = "frmUseSingleOrDefault";
            this.Load += new System.EventHandler(this.frmUseSingleOrDefault_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSingleOrDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
