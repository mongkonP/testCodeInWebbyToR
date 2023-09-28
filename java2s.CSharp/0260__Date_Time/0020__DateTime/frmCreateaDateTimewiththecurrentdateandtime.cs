using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0020__DateTime
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/CreateaDateTimewiththecurrentdateandtime.htm
    public partial  class frmCreateaDateTimewiththecurrentdateandtime:Form
    {
        public frmCreateaDateTimewiththecurrentdateandtime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaDateTimewiththecurrentdateandtime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaDateTimewiththecurrentdateandtime";
            this.Text = "frmCreateaDateTimewiththecurrentdateandtime";
            this.Load += new System.EventHandler(this.frmCreateaDateTimewiththecurrentdateandtime_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaDateTimewiththecurrentdateandtime_Load(object sender, EventArgs e)
        {

        }
    }
}
