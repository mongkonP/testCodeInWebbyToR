using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0240__NumericUpDown
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/NumericUpDownvalidatingevent.htm
    public partial  class frmNumericUpDownvalidatingevent:Form
    {
        public frmNumericUpDownvalidatingevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericUpDownvalidatingevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericUpDownvalidatingevent";
            this.Text = "frmNumericUpDownvalidatingevent";
            this.Load += new System.EventHandler(this.frmNumericUpDownvalidatingevent_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericUpDownvalidatingevent_Load(object sender, EventArgs e)
        {

        }
    }
}
