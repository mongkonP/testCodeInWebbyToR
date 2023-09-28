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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/NumericUpDownvalidatedevent.htm
    public partial  class frmNumericUpDownvalidatedevent:Form
    {
        public frmNumericUpDownvalidatedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericUpDownvalidatedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericUpDownvalidatedevent";
            this.Text = "frmNumericUpDownvalidatedevent";
            this.Load += new System.EventHandler(this.frmNumericUpDownvalidatedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericUpDownvalidatedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
