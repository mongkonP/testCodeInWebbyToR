using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0360__GC
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/weakreferences.htm
    public partial  class frmweakreferences:Form
    {
        public frmweakreferences()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmweakreferences
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmweakreferences";
            this.Text = "frmweakreferences";
            this.Load += new System.EventHandler(this.frmweakreferences_Load);
            this.ResumeLayout(false);

        }

        private void frmweakreferences_Load(object sender, EventArgs e)
        {

        }
    }
}
