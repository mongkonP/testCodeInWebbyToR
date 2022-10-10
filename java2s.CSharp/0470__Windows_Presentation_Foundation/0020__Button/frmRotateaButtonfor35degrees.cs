using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0020__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotateaButtonfor35degrees.htm
    public partial  class frmRotateaButtonfor35degrees:Form
    {
        public frmRotateaButtonfor35degrees()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotateaButtonfor35degrees
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotateaButtonfor35degrees";
            this.Text = "frmRotateaButtonfor35degrees";
            this.Load += new System.EventHandler(this.frmRotateaButtonfor35degrees_Load);
            this.ResumeLayout(false);

        }

        private void frmRotateaButtonfor35degrees_Load(object sender, EventArgs e)
        {

        }
    }
}
