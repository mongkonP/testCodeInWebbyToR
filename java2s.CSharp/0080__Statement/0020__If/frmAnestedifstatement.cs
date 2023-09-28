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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Anestedifstatement.htm
    public partial  class frmAnestedifstatement:Form
    {
        public frmAnestedifstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnestedifstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnestedifstatement";
            this.Text = "frmAnestedifstatement";
            this.Load += new System.EventHandler(this.frmAnestedifstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmAnestedifstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
