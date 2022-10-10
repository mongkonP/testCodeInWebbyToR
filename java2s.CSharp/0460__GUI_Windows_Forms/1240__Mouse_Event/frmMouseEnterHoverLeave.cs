using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1240__Mouse_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MouseEnterHoverLeave.htm
    public partial  class frmMouseEnterHoverLeave:Form
    {
        public frmMouseEnterHoverLeave()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMouseEnterHoverLeave
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMouseEnterHoverLeave";
            this.Text = "frmMouseEnterHoverLeave";
            this.Load += new System.EventHandler(this.frmMouseEnterHoverLeave_Load);
            this.ResumeLayout(false);

        }

        private void frmMouseEnterHoverLeave_Load(object sender, EventArgs e)
        {

        }
    }
}
