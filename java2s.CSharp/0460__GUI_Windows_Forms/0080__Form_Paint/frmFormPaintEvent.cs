using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0080__Form_Paint
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormPaintEvent.htm
    public partial  class frmFormPaintEvent:Form
    {
        public frmFormPaintEvent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormPaintEvent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormPaintEvent";
            this.Text = "frmFormPaintEvent";
            this.Load += new System.EventHandler(this.frmFormPaintEvent_Load);
            this.ResumeLayout(false);

        }

        private void frmFormPaintEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
