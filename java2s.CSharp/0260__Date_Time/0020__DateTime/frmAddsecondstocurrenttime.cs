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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/Addsecondstocurrenttime.htm
    public partial  class frmAddsecondstocurrenttime:Form
    {
        public frmAddsecondstocurrenttime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddsecondstocurrenttime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddsecondstocurrenttime";
            this.Text = "frmAddsecondstocurrenttime";
            this.Load += new System.EventHandler(this.frmAddsecondstocurrenttime_Load);
            this.ResumeLayout(false);

        }

        private void frmAddsecondstocurrenttime_Load(object sender, EventArgs e)
        {

        }
    }
}
