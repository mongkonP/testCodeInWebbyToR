using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0020__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ApplicationStartupPath.htm
    public partial  class frmApplicationStartupPath:Form
    {
        public frmApplicationStartupPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationStartupPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationStartupPath";
            this.Text = "frmApplicationStartupPath";
            this.Load += new System.EventHandler(this.frmApplicationStartupPath_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationStartupPath_Load(object sender, EventArgs e)
        {

        }
    }
}
