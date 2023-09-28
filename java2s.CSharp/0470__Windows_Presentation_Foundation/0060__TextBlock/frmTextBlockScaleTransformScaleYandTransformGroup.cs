using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0060__TextBlock
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TextBlockScaleTransformScaleYandTransformGroup.htm
    public partial  class frmTextBlockScaleTransformScaleYandTransformGroup:Form
    {
        public frmTextBlockScaleTransformScaleYandTransformGroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBlockScaleTransformScaleYandTransformGroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBlockScaleTransformScaleYandTransformGroup";
            this.Text = "frmTextBlockScaleTransformScaleYandTransformGroup";
            this.Load += new System.EventHandler(this.frmTextBlockScaleTransformScaleYandTransformGroup_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBlockScaleTransformScaleYandTransformGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
