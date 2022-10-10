using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0360__Ico
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Loadanicofile.htm
    public partial  class frmLoadanicofile:Form
    {
        public frmLoadanicofile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadanicofile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadanicofile";
            this.Text = "frmLoadanicofile";
            this.Load += new System.EventHandler(this.frmLoadanicofile_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadanicofile_Load(object sender, EventArgs e)
        {

        }
    }
}
