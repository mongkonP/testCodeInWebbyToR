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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/NumericUpDownValuechangedeventhandler.htm
    public partial  class frmNumericUpDownValuechangedeventhandler:Form
    {
        public frmNumericUpDownValuechangedeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericUpDownValuechangedeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericUpDownValuechangedeventhandler";
            this.Text = "frmNumericUpDownValuechangedeventhandler";
            this.Load += new System.EventHandler(this.frmNumericUpDownValuechangedeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericUpDownValuechangedeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
