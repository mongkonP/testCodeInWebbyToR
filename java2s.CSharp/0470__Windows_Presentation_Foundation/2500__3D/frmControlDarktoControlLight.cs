using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2500__3D
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ControlDarktoControlLight.htm
    public partial  class frmControlDarktoControlLight:Form
    {
        public frmControlDarktoControlLight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlDarktoControlLight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlDarktoControlLight";
            this.Text = "frmControlDarktoControlLight";
            this.Load += new System.EventHandler(this.frmControlDarktoControlLight_Load);
            this.ResumeLayout(false);

        }

        private void frmControlDarktoControlLight_Load(object sender, EventArgs e)
        {

        }
    }
}
