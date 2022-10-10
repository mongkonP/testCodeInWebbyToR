using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Addaneventhandlertoanelementusingcode.htm
    public partial  class frmAddaneventhandlertoanelementusingcode:Form
    {
        public frmAddaneventhandlertoanelementusingcode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaneventhandlertoanelementusingcode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaneventhandlertoanelementusingcode";
            this.Text = "frmAddaneventhandlertoanelementusingcode";
            this.Load += new System.EventHandler(this.frmAddaneventhandlertoanelementusingcode_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaneventhandlertoanelementusingcode_Load(object sender, EventArgs e)
        {

        }
    }
}
