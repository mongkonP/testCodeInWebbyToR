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
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/DateTimeFormatting.htm
    public partial  class frmDateTimeFormatting:Form
    {
        public frmDateTimeFormatting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDateTimeFormatting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDateTimeFormatting";
            this.Text = "frmDateTimeFormatting";
            this.Load += new System.EventHandler(this.frmDateTimeFormatting_Load);
            this.ResumeLayout(false);

        }

        private void frmDateTimeFormatting_Load(object sender, EventArgs e)
        {

        }
    }
}
