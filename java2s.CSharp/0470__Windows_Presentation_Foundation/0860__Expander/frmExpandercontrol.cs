using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0860__Expander
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Expandercontrol.htm
    public partial  class frmExpandercontrol:Form
    {
        public frmExpandercontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExpandercontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExpandercontrol";
            this.Text = "frmExpandercontrol";
            this.Load += new System.EventHandler(this.frmExpandercontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmExpandercontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
