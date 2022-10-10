using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0161__CheckBox_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate.htm
    public partial  class frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate:Form
    {
        public frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate";
            this.Text = "frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate";
            this.Load += new System.EventHandler(this.frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlesCheckBoxIndeterminateeventswhenaCheckBoxchangestoaindeterminatestate_Load(object sender, EventArgs e)
        {

        }
    }
}
