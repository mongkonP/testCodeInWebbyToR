using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0160__Regex_Phone_number
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/RegularExpressionphonenumber.htm
    public partial  class frmRegularExpressionphonenumber:Form
    {
        public frmRegularExpressionphonenumber()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegularExpressionphonenumber
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegularExpressionphonenumber";
            this.Text = "frmRegularExpressionphonenumber";
            this.Load += new System.EventHandler(this.frmRegularExpressionphonenumber_Load);
            this.ResumeLayout(false);

        }

        private void frmRegularExpressionphonenumber_Load(object sender, EventArgs e)
        {

        }
    }
}
