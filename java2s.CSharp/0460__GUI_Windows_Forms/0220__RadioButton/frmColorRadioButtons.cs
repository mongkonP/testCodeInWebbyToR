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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ColorRadioButtons.htm
    public partial  class frmColorRadioButtons:Form
    {
        public frmColorRadioButtons()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColorRadioButtons
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColorRadioButtons";
            this.Text = "frmColorRadioButtons";
            this.Load += new System.EventHandler(this.frmColorRadioButtons_Load);
            this.ResumeLayout(false);

        }

        private void frmColorRadioButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
