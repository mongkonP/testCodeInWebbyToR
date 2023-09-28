using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0100__TextRange
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListentomousedowneventforRun.htm
    public partial  class frmListentomousedowneventforRun:Form
    {
        public frmListentomousedowneventforRun()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListentomousedowneventforRun
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListentomousedowneventforRun";
            this.Text = "frmListentomousedowneventforRun";
            this.Load += new System.EventHandler(this.frmListentomousedowneventforRun_Load);
            this.ResumeLayout(false);

        }

        private void frmListentomousedowneventforRun_Load(object sender, EventArgs e)
        {

        }
    }
}
