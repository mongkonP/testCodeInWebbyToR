using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DiscretePointJumps.htm
    public partial  class frmDiscretePointJumps:Form
    {
        public frmDiscretePointJumps()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDiscretePointJumps
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDiscretePointJumps";
            this.Text = "frmDiscretePointJumps";
            this.Load += new System.EventHandler(this.frmDiscretePointJumps_Load);
            this.ResumeLayout(false);

        }

        private void frmDiscretePointJumps_Load(object sender, EventArgs e)
        {

        }
    }
}
