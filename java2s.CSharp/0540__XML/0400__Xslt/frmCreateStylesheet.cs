using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0400__Xslt
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/CreateStylesheet.htm
    public partial  class frmCreateStylesheet:Form
    {
        public frmCreateStylesheet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateStylesheet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateStylesheet";
            this.Text = "frmCreateStylesheet";
            this.Load += new System.EventHandler(this.frmCreateStylesheet_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateStylesheet_Load(object sender, EventArgs e)
        {

        }
    }
}
