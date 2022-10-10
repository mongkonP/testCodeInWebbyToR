using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PressF1togethelp.htm
    public partial  class frmPressF1togethelp:Form
    {
        public frmPressF1togethelp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPressF1togethelp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPressF1togethelp";
            this.Text = "frmPressF1togethelp";
            this.Load += new System.EventHandler(this.frmPressF1togethelp_Load);
            this.ResumeLayout(false);

        }

        private void frmPressF1togethelp_Load(object sender, EventArgs e)
        {

        }
    }
}
