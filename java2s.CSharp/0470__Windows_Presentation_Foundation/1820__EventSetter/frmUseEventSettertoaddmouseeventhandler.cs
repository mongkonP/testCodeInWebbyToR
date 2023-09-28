using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1820__EventSetter
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseEventSettertoaddmouseeventhandler.htm
    public partial  class frmUseEventSettertoaddmouseeventhandler:Form
    {
        public frmUseEventSettertoaddmouseeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseEventSettertoaddmouseeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseEventSettertoaddmouseeventhandler";
            this.Text = "frmUseEventSettertoaddmouseeventhandler";
            this.Load += new System.EventHandler(this.frmUseEventSettertoaddmouseeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmUseEventSettertoaddmouseeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
