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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/UsetheNowandUtcNowpropertiestogetthecurrrentdateandtime.htm
    public partial  class frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime:Form
    {
        public frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime";
            this.Text = "frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime";
            this.Load += new System.EventHandler(this.frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime_Load);
            this.ResumeLayout(false);

        }

        private void frmUsetheNowandUtcNowpropertiestogetthecurrrentdateandtime_Load(object sender, EventArgs e)
        {

        }
    }
}
