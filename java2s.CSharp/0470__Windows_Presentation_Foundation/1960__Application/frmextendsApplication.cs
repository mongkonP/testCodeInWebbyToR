using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/extendsApplication.htm
    public partial  class frmextendsApplication:Form
    {
        public frmextendsApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsApplication";
            this.Text = "frmextendsApplication";
            this.Load += new System.EventHandler(this.frmextendsApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
