using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0060__DateTime_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/FormatDayOfWeek.htm
    public partial  class frmFormatDayOfWeek:Form
    {
        public frmFormatDayOfWeek()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatDayOfWeek
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatDayOfWeek";
            this.Text = "frmFormatDayOfWeek";
            this.Load += new System.EventHandler(this.frmFormatDayOfWeek_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatDayOfWeek_Load(object sender, EventArgs e)
        {

        }
    }
}
