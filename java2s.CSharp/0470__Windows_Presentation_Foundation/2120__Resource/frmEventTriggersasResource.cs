using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2120__Resource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EventTriggersasResource.htm
    public partial  class frmEventTriggersasResource:Form
    {
        public frmEventTriggersasResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventTriggersasResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventTriggersasResource";
            this.Text = "frmEventTriggersasResource";
            this.Load += new System.EventHandler(this.frmEventTriggersasResource_Load);
            this.ResumeLayout(false);

        }

        private void frmEventTriggersasResource_Load(object sender, EventArgs e)
        {

        }
    }
}
