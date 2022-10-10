using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0060__Form_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Painttwoformswithonepainteventhandler.htm
    public partial  class frmPainttwoformswithonepainteventhandler:Form
    {
        public frmPainttwoformswithonepainteventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPainttwoformswithonepainteventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPainttwoformswithonepainteventhandler";
            this.Text = "frmPainttwoformswithonepainteventhandler";
            this.Load += new System.EventHandler(this.frmPainttwoformswithonepainteventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmPainttwoformswithonepainteventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
