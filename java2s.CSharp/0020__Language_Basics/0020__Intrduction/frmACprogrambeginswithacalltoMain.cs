using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0020__Intrduction
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/ACprogrambeginswithacalltoMain.htm
    public partial  class frmACprogrambeginswithacalltoMain:Form
    {
        public frmACprogrambeginswithacalltoMain()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmACprogrambeginswithacalltoMain
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmACprogrambeginswithacalltoMain";
            this.Text = "frmACprogrambeginswithacalltoMain";
            this.Load += new System.EventHandler(this.frmACprogrambeginswithacalltoMain_Load);
            this.ResumeLayout(false);

        }

        private void frmACprogrambeginswithacalltoMain_Load(object sender, EventArgs e)
        {

        }
    }
}
