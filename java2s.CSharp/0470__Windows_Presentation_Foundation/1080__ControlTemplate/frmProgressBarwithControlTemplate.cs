using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1080__ControlTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProgressBarwithControlTemplate.htm
    public partial  class frmProgressBarwithControlTemplate:Form
    {
        public frmProgressBarwithControlTemplate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgressBarwithControlTemplate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgressBarwithControlTemplate";
            this.Text = "frmProgressBarwithControlTemplate";
            this.Load += new System.EventHandler(this.frmProgressBarwithControlTemplate_Load);
            this.ResumeLayout(false);

        }

        private void frmProgressBarwithControlTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
