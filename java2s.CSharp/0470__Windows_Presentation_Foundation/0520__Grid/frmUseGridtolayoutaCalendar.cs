using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseGridtolayoutaCalendar.htm
    public partial  class frmUseGridtolayoutaCalendar:Form
    {
        public frmUseGridtolayoutaCalendar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseGridtolayoutaCalendar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseGridtolayoutaCalendar";
            this.Text = "frmUseGridtolayoutaCalendar";
            this.Load += new System.EventHandler(this.frmUseGridtolayoutaCalendar_Load);
            this.ResumeLayout(false);

        }

        private void frmUseGridtolayoutaCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
