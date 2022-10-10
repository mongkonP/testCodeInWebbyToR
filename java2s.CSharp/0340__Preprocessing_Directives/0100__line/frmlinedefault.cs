using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0340__Preprocessing_Directives.C0100__line
{
    //http://www.java2s.com/Tutorial/CSharp/0340__Preprocessing-Directives/linedefault.htm
    public partial  class frmlinedefault:Form
    {
        public frmlinedefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmlinedefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmlinedefault";
            this.Text = "frmlinedefault";
            this.Load += new System.EventHandler(this.frmlinedefault_Load);
            this.ResumeLayout(false);

        }

        private void frmlinedefault_Load(object sender, EventArgs e)
        {

        }
    }
}
