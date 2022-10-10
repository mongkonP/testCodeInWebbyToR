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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PutaControlTemplateintoaStyle.htm
    public partial  class frmPutaControlTemplateintoaStyle:Form
    {
        public frmPutaControlTemplateintoaStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPutaControlTemplateintoaStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPutaControlTemplateintoaStyle";
            this.Text = "frmPutaControlTemplateintoaStyle";
            this.Load += new System.EventHandler(this.frmPutaControlTemplateintoaStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmPutaControlTemplateintoaStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
