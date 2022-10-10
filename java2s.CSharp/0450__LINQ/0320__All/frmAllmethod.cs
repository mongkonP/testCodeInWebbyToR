using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0320__All
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Allmethod.htm
    public partial  class frmAllmethod:Form
    {
        public frmAllmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllmethod";
            this.Text = "frmAllmethod";
            this.Load += new System.EventHandler(this.frmAllmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAllmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
