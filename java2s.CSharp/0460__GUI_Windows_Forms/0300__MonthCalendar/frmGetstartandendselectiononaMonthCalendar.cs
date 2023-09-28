using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0300__MonthCalendar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/GetstartandendselectiononaMonthCalendar.htm
    public partial  class frmGetstartandendselectiononaMonthCalendar:Form
    {
        public frmGetstartandendselectiononaMonthCalendar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetstartandendselectiononaMonthCalendar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetstartandendselectiononaMonthCalendar";
            this.Text = "frmGetstartandendselectiononaMonthCalendar";
            this.Load += new System.EventHandler(this.frmGetstartandendselectiononaMonthCalendar_Load);
            this.ResumeLayout(false);

        }

        private void frmGetstartandendselectiononaMonthCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
