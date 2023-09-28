using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1840__EventTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Startingananimationwithatrigger.htm
    public partial  class frmStartingananimationwithatrigger:Form
    {
        public frmStartingananimationwithatrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStartingananimationwithatrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStartingananimationwithatrigger";
            this.Text = "frmStartingananimationwithatrigger";
            this.Load += new System.EventHandler(this.frmStartingananimationwithatrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmStartingananimationwithatrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
