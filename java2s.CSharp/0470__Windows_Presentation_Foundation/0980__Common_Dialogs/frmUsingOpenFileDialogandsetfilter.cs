using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0980__Common_Dialogs
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingOpenFileDialogandsetfilter.htm
    public partial  class frmUsingOpenFileDialogandsetfilter:Form
    {
        public frmUsingOpenFileDialogandsetfilter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingOpenFileDialogandsetfilter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingOpenFileDialogandsetfilter";
            this.Text = "frmUsingOpenFileDialogandsetfilter";
            this.Load += new System.EventHandler(this.frmUsingOpenFileDialogandsetfilter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingOpenFileDialogandsetfilter_Load(object sender, EventArgs e)
        {

        }
    }
}
