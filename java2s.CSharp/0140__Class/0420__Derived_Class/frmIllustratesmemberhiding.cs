using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0420__Derived_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Illustratesmemberhiding.htm
    public partial  class frmIllustratesmemberhiding:Form
    {
        public frmIllustratesmemberhiding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustratesmemberhiding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustratesmemberhiding";
            this.Text = "frmIllustratesmemberhiding";
            this.Load += new System.EventHandler(this.frmIllustratesmemberhiding_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustratesmemberhiding_Load(object sender, EventArgs e)
        {

        }
    }
}
