using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0020__If
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/TheifStatement.htm
    public partial  class frmTheifStatement:Form
    {
        public frmTheifStatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheifStatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheifStatement";
            this.Text = "frmTheifStatement";
            this.Load += new System.EventHandler(this.frmTheifStatement_Load);
            this.ResumeLayout(false);

        }

        private void frmTheifStatement_Load(object sender, EventArgs e)
        {

        }
    }
}
