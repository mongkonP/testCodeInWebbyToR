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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaCheckBoxandlinkeventhandler.htm
    public partial  class frmCreateaCheckBoxandlinkeventhandler:Form
    {
        public frmCreateaCheckBoxandlinkeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaCheckBoxandlinkeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaCheckBoxandlinkeventhandler";
            this.Text = "frmCreateaCheckBoxandlinkeventhandler";
            this.Load += new System.EventHandler(this.frmCreateaCheckBoxandlinkeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaCheckBoxandlinkeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
