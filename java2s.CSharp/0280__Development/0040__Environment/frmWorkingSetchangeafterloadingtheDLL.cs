using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/WorkingSetchangeafterloadingtheDLL.htm
    public partial  class frmWorkingSetchangeafterloadingtheDLL:Form
    {
        public frmWorkingSetchangeafterloadingtheDLL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWorkingSetchangeafterloadingtheDLL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWorkingSetchangeafterloadingtheDLL";
            this.Text = "frmWorkingSetchangeafterloadingtheDLL";
            this.Load += new System.EventHandler(this.frmWorkingSetchangeafterloadingtheDLL_Load);
            this.ResumeLayout(false);

        }

        private void frmWorkingSetchangeafterloadingtheDLL_Load(object sender, EventArgs e)
        {

        }
    }
}
