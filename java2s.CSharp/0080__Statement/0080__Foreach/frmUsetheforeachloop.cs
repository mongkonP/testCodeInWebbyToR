using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0080__Foreach
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Usetheforeachloop.htm
    public partial  class frmUsetheforeachloop:Form
    {
        public frmUsetheforeachloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheforeachloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheforeachloop";
            this.Text = "frmUsetheforeachloop";
            this.Load += new System.EventHandler(this.frmUsetheforeachloop_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheforeachloop_Load(object sender, EventArgs e)
        {

        }
    }
}
