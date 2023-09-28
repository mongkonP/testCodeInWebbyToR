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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/NumericUpDownvaluechangedevent.htm
    public partial  class frmNumericUpDownvaluechangedevent:Form
    {
        public frmNumericUpDownvaluechangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericUpDownvaluechangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericUpDownvaluechangedevent";
            this.Text = "frmNumericUpDownvaluechangedevent";
            this.Load += new System.EventHandler(this.frmNumericUpDownvaluechangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericUpDownvaluechangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
