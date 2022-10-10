using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1621__Transform
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Translate.htm
    public partial  class frmTranslate:Form
    {
        public frmTranslate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTranslate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTranslate";
            this.Text = "frmTranslate";
            this.Load += new System.EventHandler(this.frmTranslate_Load);
            this.ResumeLayout(false);

        }

        private void frmTranslate_Load(object sender, EventArgs e)
        {

        }
    }
}
