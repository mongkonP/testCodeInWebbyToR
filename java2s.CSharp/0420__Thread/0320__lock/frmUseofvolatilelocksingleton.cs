using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0320__lock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Useofvolatilelocksingleton.htm
    public partial  class frmUseofvolatilelocksingleton:Form
    {
        public frmUseofvolatilelocksingleton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseofvolatilelocksingleton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseofvolatilelocksingleton";
            this.Text = "frmUseofvolatilelocksingleton";
            this.Load += new System.EventHandler(this.frmUseofvolatilelocksingleton_Load);
            this.ResumeLayout(false);

        }

        private void frmUseofvolatilelocksingleton_Load(object sender, EventArgs e)
        {

        }
    }
}
