using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1080__ControlTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ControlTemplatethatRespectsMoreProperties.htm
    public partial  class frmControlTemplatethatRespectsMoreProperties:Form
    {
        public frmControlTemplatethatRespectsMoreProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControlTemplatethatRespectsMoreProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControlTemplatethatRespectsMoreProperties";
            this.Text = "frmControlTemplatethatRespectsMoreProperties";
            this.Load += new System.EventHandler(this.frmControlTemplatethatRespectsMoreProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmControlTemplatethatRespectsMoreProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
