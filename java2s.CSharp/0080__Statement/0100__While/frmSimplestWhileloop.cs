using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0100__While
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/SimplestWhileloop.htm
    public partial  class frmSimplestWhileloop:Form
    {
        public frmSimplestWhileloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplestWhileloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplestWhileloop";
            this.Text = "frmSimplestWhileloop";
            this.Load += new System.EventHandler(this.frmSimplestWhileloop_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplestWhileloop_Load(object sender, EventArgs e)
        {

        }
    }
}
