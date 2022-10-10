using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/InheritApplicationclassandlistentosessionendingevent.htm
    public partial  class frmInheritApplicationclassandlistentosessionendingevent:Form
    {
        public frmInheritApplicationclassandlistentosessionendingevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritApplicationclassandlistentosessionendingevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritApplicationclassandlistentosessionendingevent";
            this.Text = "frmInheritApplicationclassandlistentosessionendingevent";
            this.Load += new System.EventHandler(this.frmInheritApplicationclassandlistentosessionendingevent_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritApplicationclassandlistentosessionendingevent_Load(object sender, EventArgs e)
        {

        }
    }
}
