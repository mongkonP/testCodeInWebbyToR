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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DefinetheTabOrderofUIElementsinaForm.htm
    public partial  class frmDefinetheTabOrderofUIElementsinaForm:Form
    {
        public frmDefinetheTabOrderofUIElementsinaForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefinetheTabOrderofUIElementsinaForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefinetheTabOrderofUIElementsinaForm";
            this.Text = "frmDefinetheTabOrderofUIElementsinaForm";
            this.Load += new System.EventHandler(this.frmDefinetheTabOrderofUIElementsinaForm_Load);
            this.ResumeLayout(false);

        }

        private void frmDefinetheTabOrderofUIElementsinaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
