using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1040__Forms
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ControltheSizeofUIElementsinaForm.htm
    public partial  class frmControltheSizeofUIElementsinaForm:Form
    {
        public frmControltheSizeofUIElementsinaForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControltheSizeofUIElementsinaForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControltheSizeofUIElementsinaForm";
            this.Text = "frmControltheSizeofUIElementsinaForm";
            this.Load += new System.EventHandler(this.frmControltheSizeofUIElementsinaForm_Load);
            this.ResumeLayout(false);

        }

        private void frmControltheSizeofUIElementsinaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
