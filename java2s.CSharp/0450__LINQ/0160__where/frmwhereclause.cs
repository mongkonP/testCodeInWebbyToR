using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/whereclause.htm
    public partial  class frmwhereclause:Form
    {
        public frmwhereclause()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmwhereclause
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmwhereclause";
            this.Text = "frmwhereclause";
            this.Load += new System.EventHandler(this.frmwhereclause_Load);
            this.ResumeLayout(false);

        }

        private void frmwhereclause_Load(object sender, EventArgs e)
        {

        }
    }
}
