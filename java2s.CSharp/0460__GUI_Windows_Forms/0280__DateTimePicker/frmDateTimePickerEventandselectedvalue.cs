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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DateTimePickerEventandselectedvalue.htm
    public partial  class frmDateTimePickerEventandselectedvalue:Form
    {
        public frmDateTimePickerEventandselectedvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDateTimePickerEventandselectedvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDateTimePickerEventandselectedvalue";
            this.Text = "frmDateTimePickerEventandselectedvalue";
            this.Load += new System.EventHandler(this.frmDateTimePickerEventandselectedvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmDateTimePickerEventandselectedvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
