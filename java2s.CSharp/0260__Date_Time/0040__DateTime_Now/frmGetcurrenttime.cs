using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0040__DateTime_Now
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/Getcurrenttime.htm
    public partial  class frmGetcurrenttime:Form
    {
        public frmGetcurrenttime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetcurrenttime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetcurrenttime";
            this.Text = "frmGetcurrenttime";
            this.Load += new System.EventHandler(this.frmGetcurrenttime_Load);
            this.ResumeLayout(false);

        }

        private void frmGetcurrenttime_Load(object sender, EventArgs e)
        {

        }
    }
}
