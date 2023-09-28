using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0180__CheckBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CheckedChangedeventforCheckBox.htm
    public partial  class frmCheckedChangedeventforCheckBox:Form
    {
        public frmCheckedChangedeventforCheckBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckedChangedeventforCheckBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckedChangedeventforCheckBox";
            this.Text = "frmCheckedChangedeventforCheckBox";
            this.Load += new System.EventHandler(this.frmCheckedChangedeventforCheckBox_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckedChangedeventforCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
