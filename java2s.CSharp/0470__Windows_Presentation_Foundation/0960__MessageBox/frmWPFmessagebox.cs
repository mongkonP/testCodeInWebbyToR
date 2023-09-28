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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WPFmessagebox.htm
    public partial  class frmWPFmessagebox:Form
    {
        public frmWPFmessagebox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWPFmessagebox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWPFmessagebox";
            this.Text = "frmWPFmessagebox";
            this.Load += new System.EventHandler(this.frmWPFmessagebox_Load);
            this.ResumeLayout(false);

        }

        private void frmWPFmessagebox_Load(object sender, EventArgs e)
        {

        }
    }
}
