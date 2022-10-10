using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0960__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetMessageHeaderandButtonforMessageBox.htm
    public partial  class frmSetMessageHeaderandButtonforMessageBox:Form
    {
        public frmSetMessageHeaderandButtonforMessageBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetMessageHeaderandButtonforMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetMessageHeaderandButtonforMessageBox";
            this.Text = "frmSetMessageHeaderandButtonforMessageBox";
            this.Load += new System.EventHandler(this.frmSetMessageHeaderandButtonforMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void frmSetMessageHeaderandButtonforMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
