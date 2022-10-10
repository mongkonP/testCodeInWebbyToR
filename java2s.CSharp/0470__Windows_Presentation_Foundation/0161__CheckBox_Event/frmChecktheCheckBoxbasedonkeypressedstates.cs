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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChecktheCheckBoxbasedonkeypressedstates.htm
    public partial  class frmChecktheCheckBoxbasedonkeypressedstates:Form
    {
        public frmChecktheCheckBoxbasedonkeypressedstates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChecktheCheckBoxbasedonkeypressedstates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChecktheCheckBoxbasedonkeypressedstates";
            this.Text = "frmChecktheCheckBoxbasedonkeypressedstates";
            this.Load += new System.EventHandler(this.frmChecktheCheckBoxbasedonkeypressedstates_Load);
            this.ResumeLayout(false);

        }

        private void frmChecktheCheckBoxbasedonkeypressedstates_Load(object sender, EventArgs e)
        {

        }
    }
}
