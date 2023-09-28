using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1860__Key_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SuppressKeyboardandMouseEvents.htm
    public partial  class frmSuppressKeyboardandMouseEvents:Form
    {
        public frmSuppressKeyboardandMouseEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSuppressKeyboardandMouseEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSuppressKeyboardandMouseEvents";
            this.Text = "frmSuppressKeyboardandMouseEvents";
            this.Load += new System.EventHandler(this.frmSuppressKeyboardandMouseEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmSuppressKeyboardandMouseEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
