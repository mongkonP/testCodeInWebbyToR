using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Changewindowcursor.htm
    public partial  class frmChangewindowcursor:Form
    {
        public frmChangewindowcursor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangewindowcursor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangewindowcursor";
            this.Text = "frmChangewindowcursor";
            this.Load += new System.EventHandler(this.frmChangewindowcursor_Load);
            this.ResumeLayout(false);

        }

        private void frmChangewindowcursor_Load(object sender, EventArgs e)
        {

        }
    }
}
