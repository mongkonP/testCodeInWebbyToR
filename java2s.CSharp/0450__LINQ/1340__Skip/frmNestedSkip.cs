using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1340__Skip
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/NestedSkip.htm
    public partial  class frmNestedSkip:Form
    {
        public frmNestedSkip()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedSkip
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedSkip";
            this.Text = "frmNestedSkip";
            this.Load += new System.EventHandler(this.frmNestedSkip_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedSkip_Load(object sender, EventArgs e)
        {

        }
    }
}
