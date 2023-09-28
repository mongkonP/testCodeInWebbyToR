using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0020__Regular_Expression
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/Reverse.htm
    public partial  class frmReverse:Form
    {
        public frmReverse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReverse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReverse";
            this.Text = "frmReverse";
            this.Load += new System.EventHandler(this.frmReverse_Load);
            this.ResumeLayout(false);

        }

        private void frmReverse_Load(object sender, EventArgs e)
        {

        }
    }
}
