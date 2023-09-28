using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CalculateButtonsizebasedonitsText.htm
    public partial  class frmCalculateButtonsizebasedonitsText:Form
    {
        public frmCalculateButtonsizebasedonitsText()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalculateButtonsizebasedonitsText
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCalculateButtonsizebasedonitsText";
            this.Text = "frmCalculateButtonsizebasedonitsText";
            this.Load += new System.EventHandler(this.frmCalculateButtonsizebasedonitsText_Load);
            this.ResumeLayout(false);

        }

        private void frmCalculateButtonsizebasedonitsText_Load(object sender, EventArgs e)
        {

        }
    }
}
