using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2140__DataTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DataTemplateforInt32.htm
    public partial  class frmDataTemplateforInt32:Form
    {
        public frmDataTemplateforInt32()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataTemplateforInt32
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataTemplateforInt32";
            this.Text = "frmDataTemplateforInt32";
            this.Load += new System.EventHandler(this.frmDataTemplateforInt32_Load);
            this.ResumeLayout(false);

        }

        private void frmDataTemplateforInt32_Load(object sender, EventArgs e)
        {

        }
    }
}
