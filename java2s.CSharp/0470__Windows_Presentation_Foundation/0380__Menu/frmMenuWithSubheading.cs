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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MenuWithSubheading.htm
    public partial  class frmMenuWithSubheading:Form
    {
        public frmMenuWithSubheading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMenuWithSubheading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMenuWithSubheading";
            this.Text = "frmMenuWithSubheading";
            this.Load += new System.EventHandler(this.frmMenuWithSubheading_Load);
            this.ResumeLayout(false);

        }

        private void frmMenuWithSubheading_Load(object sender, EventArgs e)
        {

        }
    }
}
