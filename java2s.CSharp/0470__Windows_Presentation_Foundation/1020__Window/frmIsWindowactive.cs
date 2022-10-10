using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/IsWindowactive.htm
    public partial  class frmIsWindowactive:Form
    {
        public frmIsWindowactive()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsWindowactive
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsWindowactive";
            this.Text = "frmIsWindowactive";
            this.Load += new System.EventHandler(this.frmIsWindowactive_Load);
            this.ResumeLayout(false);

        }

        private void frmIsWindowactive_Load(object sender, EventArgs e)
        {

        }
    }
}
