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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Paintsarectanglewithacheckeredpattern.htm
    public partial  class frmPaintsarectanglewithacheckeredpattern:Form
    {
        public frmPaintsarectanglewithacheckeredpattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPaintsarectanglewithacheckeredpattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPaintsarectanglewithacheckeredpattern";
            this.Text = "frmPaintsarectanglewithacheckeredpattern";
            this.Load += new System.EventHandler(this.frmPaintsarectanglewithacheckeredpattern_Load);
            this.ResumeLayout(false);

        }

        private void frmPaintsarectanglewithacheckeredpattern_Load(object sender, EventArgs e)
        {

        }
    }
}
