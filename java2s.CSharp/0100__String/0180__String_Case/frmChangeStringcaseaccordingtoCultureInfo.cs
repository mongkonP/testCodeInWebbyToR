using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0180__String_Case
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/ChangeStringcaseaccordingtoCultureInfo.htm
    public partial  class frmChangeStringcaseaccordingtoCultureInfo:Form
    {
        public frmChangeStringcaseaccordingtoCultureInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangeStringcaseaccordingtoCultureInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangeStringcaseaccordingtoCultureInfo";
            this.Text = "frmChangeStringcaseaccordingtoCultureInfo";
            this.Load += new System.EventHandler(this.frmChangeStringcaseaccordingtoCultureInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmChangeStringcaseaccordingtoCultureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
