using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Wrapthetext.htm
    public partial  class frmWrapthetext:Form
    {
        public frmWrapthetext()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWrapthetext
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWrapthetext";
            this.Text = "frmWrapthetext";
            this.Load += new System.EventHandler(this.frmWrapthetext_Load);
            this.ResumeLayout(false);

        }

        private void frmWrapthetext_Load(object sender, EventArgs e)
        {

        }
    }
}
