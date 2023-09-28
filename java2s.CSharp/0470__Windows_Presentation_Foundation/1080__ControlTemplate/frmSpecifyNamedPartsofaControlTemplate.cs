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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SpecifyNamedPartsofaControlTemplate.htm
    public partial  class frmSpecifyNamedPartsofaControlTemplate:Form
    {
        public frmSpecifyNamedPartsofaControlTemplate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSpecifyNamedPartsofaControlTemplate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSpecifyNamedPartsofaControlTemplate";
            this.Text = "frmSpecifyNamedPartsofaControlTemplate";
            this.Load += new System.EventHandler(this.frmSpecifyNamedPartsofaControlTemplate_Load);
            this.ResumeLayout(false);

        }

        private void frmSpecifyNamedPartsofaControlTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
