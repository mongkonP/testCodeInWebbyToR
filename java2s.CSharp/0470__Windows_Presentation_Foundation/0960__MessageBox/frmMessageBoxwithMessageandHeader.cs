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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MessageBoxwithMessageandHeader.htm
    public partial  class frmMessageBoxwithMessageandHeader:Form
    {
        public frmMessageBoxwithMessageandHeader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMessageBoxwithMessageandHeader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMessageBoxwithMessageandHeader";
            this.Text = "frmMessageBoxwithMessageandHeader";
            this.Load += new System.EventHandler(this.frmMessageBoxwithMessageandHeader_Load);
            this.ResumeLayout(false);

        }

        private void frmMessageBoxwithMessageandHeader_Load(object sender, EventArgs e)
        {

        }
    }
}
