using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Getfreediskspace.htm
    public partial  class frmGetfreediskspace:Form
    {
        public frmGetfreediskspace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetfreediskspace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetfreediskspace";
            this.Text = "frmGetfreediskspace";
            this.Load += new System.EventHandler(this.frmGetfreediskspace_Load);
            this.ResumeLayout(false);

        }

        private void frmGetfreediskspace_Load(object sender, EventArgs e)
        {

        }
    }
}
