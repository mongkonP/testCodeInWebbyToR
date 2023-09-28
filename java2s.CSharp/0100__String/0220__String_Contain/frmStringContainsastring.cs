using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0220__String_Contain
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringContainsastring.htm
    public partial  class frmStringContainsastring:Form
    {
        public frmStringContainsastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringContainsastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringContainsastring";
            this.Text = "frmStringContainsastring";
            this.Load += new System.EventHandler(this.frmStringContainsastring_Load);
            this.ResumeLayout(false);

        }

        private void frmStringContainsastring_Load(object sender, EventArgs e)
        {

        }
    }
}
