using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0080__Regex_Group
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/RegExGroup.htm
    public partial  class frmRegExGroup:Form
    {
        public frmRegExGroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegExGroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegExGroup";
            this.Text = "frmRegExGroup";
            this.Load += new System.EventHandler(this.frmRegExGroup_Load);
            this.ResumeLayout(false);

        }

        private void frmRegExGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
