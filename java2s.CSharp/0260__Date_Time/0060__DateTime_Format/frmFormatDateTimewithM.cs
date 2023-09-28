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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/FormatDateTimewithM.htm
    public partial  class frmFormatDateTimewithM:Form
    {
        public frmFormatDateTimewithM()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatDateTimewithM
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatDateTimewithM";
            this.Text = "frmFormatDateTimewithM";
            this.Load += new System.EventHandler(this.frmFormatDateTimewithM_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatDateTimewithM_Load(object sender, EventArgs e)
        {

        }
    }
}
