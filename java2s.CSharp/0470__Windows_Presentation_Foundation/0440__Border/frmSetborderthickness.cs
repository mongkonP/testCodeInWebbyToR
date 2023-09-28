using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Setborderthickness.htm
    public partial  class frmSetborderthickness:Form
    {
        public frmSetborderthickness()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetborderthickness
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetborderthickness";
            this.Text = "frmSetborderthickness";
            this.Load += new System.EventHandler(this.frmSetborderthickness_Load);
            this.ResumeLayout(false);

        }

        private void frmSetborderthickness_Load(object sender, EventArgs e)
        {

        }
    }
}
