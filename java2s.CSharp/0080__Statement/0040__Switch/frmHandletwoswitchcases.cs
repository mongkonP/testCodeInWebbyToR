using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0040__Switch
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Handletwoswitchcases.htm
    public partial  class frmHandletwoswitchcases:Form
    {
        public frmHandletwoswitchcases()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandletwoswitchcases
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandletwoswitchcases";
            this.Text = "frmHandletwoswitchcases";
            this.Load += new System.EventHandler(this.frmHandletwoswitchcases_Load);
            this.ResumeLayout(false);

        }

        private void frmHandletwoswitchcases_Load(object sender, EventArgs e)
        {

        }
    }
}
