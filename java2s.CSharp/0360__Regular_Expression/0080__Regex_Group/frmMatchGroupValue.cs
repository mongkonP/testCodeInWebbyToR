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
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/MatchGroupValue.htm
    public partial  class frmMatchGroupValue:Form
    {
        public frmMatchGroupValue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMatchGroupValue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMatchGroupValue";
            this.Text = "frmMatchGroupValue";
            this.Load += new System.EventHandler(this.frmMatchGroupValue_Load);
            this.ResumeLayout(false);

        }

        private void frmMatchGroupValue_Load(object sender, EventArgs e)
        {

        }
    }
}
