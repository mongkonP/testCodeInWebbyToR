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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Rotate.htm
    public partial  class frmRotate:Form
    {
        public frmRotate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotate";
            this.Text = "frmRotate";
            this.Load += new System.EventHandler(this.frmRotate_Load);
            this.ResumeLayout(false);

        }

        private void frmRotate_Load(object sender, EventArgs e)
        {

        }
    }
}
