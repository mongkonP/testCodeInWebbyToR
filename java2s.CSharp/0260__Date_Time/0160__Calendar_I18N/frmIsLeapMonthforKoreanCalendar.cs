using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0160__Calendar_I18N
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/IsLeapMonthforKoreanCalendar.htm
    public partial  class frmIsLeapMonthforKoreanCalendar:Form
    {
        public frmIsLeapMonthforKoreanCalendar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsLeapMonthforKoreanCalendar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsLeapMonthforKoreanCalendar";
            this.Text = "frmIsLeapMonthforKoreanCalendar";
            this.Load += new System.EventHandler(this.frmIsLeapMonthforKoreanCalendar_Load);
            this.ResumeLayout(false);

        }

        private void frmIsLeapMonthforKoreanCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
