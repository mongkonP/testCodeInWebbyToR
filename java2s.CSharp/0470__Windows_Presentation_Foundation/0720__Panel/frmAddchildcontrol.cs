using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0720__Panel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Addchildcontrol.htm
    public partial  class frmAddchildcontrol:Form
    {
        public frmAddchildcontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddchildcontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddchildcontrol";
            this.Text = "frmAddchildcontrol";
            this.Load += new System.EventHandler(this.frmAddchildcontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmAddchildcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
