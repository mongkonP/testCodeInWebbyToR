using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0280__DateTimePicker
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DateTimePickercustomformat.htm
    public partial  class frmDateTimePickercustomformat:Form
    {
        public frmDateTimePickercustomformat()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDateTimePickercustomformat
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDateTimePickercustomformat";
            this.Text = "frmDateTimePickercustomformat";
            this.Load += new System.EventHandler(this.frmDateTimePickercustomformat_Load);
            this.ResumeLayout(false);

        }

        private void frmDateTimePickercustomformat_Load(object sender, EventArgs e)
        {

        }
    }
}
