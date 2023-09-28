using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ImageasResource.htm
    public partial  class frmImageasResource:Form
    {
        public frmImageasResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImageasResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImageasResource";
            this.Text = "frmImageasResource";
            this.Load += new System.EventHandler(this.frmImageasResource_Load);
            this.ResumeLayout(false);

        }

        private void frmImageasResource_Load(object sender, EventArgs e)
        {

        }
    }
}
