using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0700__GroupBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GroupBoxHeaderwithmixedcontent.htm
    public partial  class frmGroupBoxHeaderwithmixedcontent:Form
    {
        public frmGroupBoxHeaderwithmixedcontent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupBoxHeaderwithmixedcontent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupBoxHeaderwithmixedcontent";
            this.Text = "frmGroupBoxHeaderwithmixedcontent";
            this.Load += new System.EventHandler(this.frmGroupBoxHeaderwithmixedcontent_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupBoxHeaderwithmixedcontent_Load(object sender, EventArgs e)
        {

        }
    }
}
