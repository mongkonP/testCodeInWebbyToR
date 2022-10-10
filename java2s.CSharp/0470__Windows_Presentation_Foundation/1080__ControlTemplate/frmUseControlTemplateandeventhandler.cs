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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseControlTemplateandeventhandler.htm
    public partial  class frmUseControlTemplateandeventhandler:Form
    {
        public frmUseControlTemplateandeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseControlTemplateandeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseControlTemplateandeventhandler";
            this.Text = "frmUseControlTemplateandeventhandler";
            this.Load += new System.EventHandler(this.frmUseControlTemplateandeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmUseControlTemplateandeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
