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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/CreatesandinitializesaJulianCalendar.htm
    public partial  class frmCreatesandinitializesaJulianCalendar:Form
    {
        public frmCreatesandinitializesaJulianCalendar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatesandinitializesaJulianCalendar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatesandinitializesaJulianCalendar";
            this.Text = "frmCreatesandinitializesaJulianCalendar";
            this.Load += new System.EventHandler(this.frmCreatesandinitializesaJulianCalendar_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatesandinitializesaJulianCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
