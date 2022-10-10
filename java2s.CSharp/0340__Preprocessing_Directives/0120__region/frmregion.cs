using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0340__Preprocessing_Directives.C0120__region
{
    //http://www.java2s.com/Tutorial/CSharp/0340__Preprocessing-Directives/region.htm
    public partial  class frmregion:Form
    {
        public frmregion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmregion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmregion";
            this.Text = "frmregion";
            this.Load += new System.EventHandler(this.frmregion_Load);
            this.ResumeLayout(false);

        }

        private void frmregion_Load(object sender, EventArgs e)
        {

        }
    }
}
