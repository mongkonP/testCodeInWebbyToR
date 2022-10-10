using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0220__RadioButton
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RadioButtonClickEvent.htm
    public partial  class frmRadioButtonClickEvent:Form
    {
        public frmRadioButtonClickEvent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRadioButtonClickEvent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRadioButtonClickEvent";
            this.Text = "frmRadioButtonClickEvent";
            this.Load += new System.EventHandler(this.frmRadioButtonClickEvent_Load);
            this.ResumeLayout(false);

        }

        private void frmRadioButtonClickEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
