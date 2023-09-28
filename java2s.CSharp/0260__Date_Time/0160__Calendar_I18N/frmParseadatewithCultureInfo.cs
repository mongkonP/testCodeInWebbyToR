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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/ParseadatewithCultureInfo.htm
    public partial  class frmParseadatewithCultureInfo:Form
    {
        public frmParseadatewithCultureInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParseadatewithCultureInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParseadatewithCultureInfo";
            this.Text = "frmParseadatewithCultureInfo";
            this.Load += new System.EventHandler(this.frmParseadatewithCultureInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmParseadatewithCultureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
