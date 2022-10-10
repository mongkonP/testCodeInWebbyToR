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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Styleresourcewithpredefinedstaticresource.htm
    public partial  class frmStyleresourcewithpredefinedstaticresource:Form
    {
        public frmStyleresourcewithpredefinedstaticresource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyleresourcewithpredefinedstaticresource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStyleresourcewithpredefinedstaticresource";
            this.Text = "frmStyleresourcewithpredefinedstaticresource";
            this.Load += new System.EventHandler(this.frmStyleresourcewithpredefinedstaticresource_Load);
            this.ResumeLayout(false);

        }

        private void frmStyleresourcewithpredefinedstaticresource_Load(object sender, EventArgs e)
        {

        }
    }
}
