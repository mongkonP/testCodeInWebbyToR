using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0200__using
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/using.htm
    public partial  class frmusing:Form
    {
        public frmusing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmusing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmusing";
            this.Text = "frmusing";
            this.Load += new System.EventHandler(this.frmusing_Load);
            this.ResumeLayout(false);

        }

        private void frmusing_Load(object sender, EventArgs e)
        {

        }
    }
}
