using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreaterectanglesinWPF.htm
    public partial  class frmCreaterectanglesinWPF:Form
    {
        public frmCreaterectanglesinWPF()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreaterectanglesinWPF
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreaterectanglesinWPF";
            this.Text = "frmCreaterectanglesinWPF";
            this.Load += new System.EventHandler(this.frmCreaterectanglesinWPF_Load);
            this.ResumeLayout(false);

        }

        private void frmCreaterectanglesinWPF_Load(object sender, EventArgs e)
        {

        }
    }
}
