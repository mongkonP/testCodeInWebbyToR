using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/UsingTheEventKeyword.htm
    public partial  class frmUsingTheEventKeyword:Form
    {
        public frmUsingTheEventKeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingTheEventKeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingTheEventKeyword";
            this.Text = "frmUsingTheEventKeyword";
            this.Load += new System.EventHandler(this.frmUsingTheEventKeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingTheEventKeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
