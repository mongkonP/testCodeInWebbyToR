using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0700__GroupBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingGroupBoxtoWindow.htm
    public partial  class frmAddingGroupBoxtoWindow:Form
    {
        public frmAddingGroupBoxtoWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingGroupBoxtoWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingGroupBoxtoWindow";
            this.Text = "frmAddingGroupBoxtoWindow";
            this.Load += new System.EventHandler(this.frmAddingGroupBoxtoWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingGroupBoxtoWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
