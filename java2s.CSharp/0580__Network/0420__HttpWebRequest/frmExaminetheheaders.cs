using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0420__HttpWebRequest
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Examinetheheaders.htm
    public partial  class frmExaminetheheaders:Form
    {
        public frmExaminetheheaders()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExaminetheheaders
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExaminetheheaders";
            this.Text = "frmExaminetheheaders";
            this.Load += new System.EventHandler(this.frmExaminetheheaders_Load);
            this.ResumeLayout(false);

        }

        private void frmExaminetheheaders_Load(object sender, EventArgs e)
        {

        }
    }
}
