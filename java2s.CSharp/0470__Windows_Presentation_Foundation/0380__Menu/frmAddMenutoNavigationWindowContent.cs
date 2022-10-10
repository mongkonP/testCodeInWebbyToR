using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0380__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddMenutoNavigationWindowContent.htm
    public partial  class frmAddMenutoNavigationWindowContent:Form
    {
        public frmAddMenutoNavigationWindowContent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddMenutoNavigationWindowContent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddMenutoNavigationWindowContent";
            this.Text = "frmAddMenutoNavigationWindowContent";
            this.Load += new System.EventHandler(this.frmAddMenutoNavigationWindowContent_Load);
            this.ResumeLayout(false);

        }

        private void frmAddMenutoNavigationWindowContent_Load(object sender, EventArgs e)
        {

        }
    }
}
