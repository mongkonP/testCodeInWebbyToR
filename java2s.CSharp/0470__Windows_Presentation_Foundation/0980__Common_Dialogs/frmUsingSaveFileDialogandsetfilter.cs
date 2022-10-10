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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingSaveFileDialogandsetfilter.htm
    public partial  class frmUsingSaveFileDialogandsetfilter:Form
    {
        public frmUsingSaveFileDialogandsetfilter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingSaveFileDialogandsetfilter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingSaveFileDialogandsetfilter";
            this.Text = "frmUsingSaveFileDialogandsetfilter";
            this.Load += new System.EventHandler(this.frmUsingSaveFileDialogandsetfilter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingSaveFileDialogandsetfilter_Load(object sender, EventArgs e)
        {

        }
    }
}
