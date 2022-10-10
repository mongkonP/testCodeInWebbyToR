using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0940__Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PropertyTrigger.htm
    public partial  class frmPropertyTrigger:Form
    {
        public frmPropertyTrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyTrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyTrigger";
            this.Text = "frmPropertyTrigger";
            this.Load += new System.EventHandler(this.frmPropertyTrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyTrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
