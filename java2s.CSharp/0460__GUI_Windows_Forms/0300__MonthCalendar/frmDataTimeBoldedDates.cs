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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DataTimeBoldedDates.htm
    public partial  class frmDataTimeBoldedDates:Form
    {
        public frmDataTimeBoldedDates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataTimeBoldedDates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataTimeBoldedDates";
            this.Text = "frmDataTimeBoldedDates";
            this.Load += new System.EventHandler(this.frmDataTimeBoldedDates_Load);
            this.ResumeLayout(false);

        }

        private void frmDataTimeBoldedDates_Load(object sender, EventArgs e)
        {

        }
    }
}
