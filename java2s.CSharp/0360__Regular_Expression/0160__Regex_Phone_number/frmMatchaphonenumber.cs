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
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/Matchaphonenumber.htm
    public partial  class frmMatchaphonenumber:Form
    {
        public frmMatchaphonenumber()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMatchaphonenumber
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMatchaphonenumber";
            this.Text = "frmMatchaphonenumber";
            this.Load += new System.EventHandler(this.frmMatchaphonenumber_Load);
            this.ResumeLayout(false);

        }

        private void frmMatchaphonenumber_Load(object sender, EventArgs e)
        {

        }
    }
}
