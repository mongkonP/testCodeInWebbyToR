using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Getahandletothecurrentappandshutitdown.htm
    public partial  class frmGetahandletothecurrentappandshutitdown:Form
    {
        public frmGetahandletothecurrentappandshutitdown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetahandletothecurrentappandshutitdown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetahandletothecurrentappandshutitdown";
            this.Text = "frmGetahandletothecurrentappandshutitdown";
            this.Load += new System.EventHandler(this.frmGetahandletothecurrentappandshutitdown_Load);
            this.ResumeLayout(false);

        }

        private void frmGetahandletothecurrentappandshutitdown_Load(object sender, EventArgs e)
        {

        }
    }
}
