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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Skipthefirstfour.htm
    public partial  class frmSkipthefirstfour:Form
    {
        public frmSkipthefirstfour()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSkipthefirstfour
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSkipthefirstfour";
            this.Text = "frmSkipthefirstfour";
            this.Load += new System.EventHandler(this.frmSkipthefirstfour_Load);
            this.ResumeLayout(false);

        }

        private void frmSkipthefirstfour_Load(object sender, EventArgs e)
        {

        }
    }
}
