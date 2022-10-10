using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0021__Button_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddUntransformedbuttontoCanvas.htm
    public partial  class frmAddUntransformedbuttontoCanvas:Form
    {
        public frmAddUntransformedbuttontoCanvas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddUntransformedbuttontoCanvas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddUntransformedbuttontoCanvas";
            this.Text = "frmAddUntransformedbuttontoCanvas";
            this.Load += new System.EventHandler(this.frmAddUntransformedbuttontoCanvas_Load);
            this.ResumeLayout(false);

        }

        private void frmAddUntransformedbuttontoCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
