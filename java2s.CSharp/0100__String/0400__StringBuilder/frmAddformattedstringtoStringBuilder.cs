using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0400__StringBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/AddformattedstringtoStringBuilder.htm
    public partial  class frmAddformattedstringtoStringBuilder:Form
    {
        public frmAddformattedstringtoStringBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddformattedstringtoStringBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddformattedstringtoStringBuilder";
            this.Text = "frmAddformattedstringtoStringBuilder";
            this.Load += new System.EventHandler(this.frmAddformattedstringtoStringBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmAddformattedstringtoStringBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
