using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Usedelegatetohandleevents.htm
    public partial  class frmUsedelegatetohandleevents:Form
    {
        public frmUsedelegatetohandleevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsedelegatetohandleevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsedelegatetohandleevents";
            this.Text = "frmUsedelegatetohandleevents";
            this.Load += new System.EventHandler(this.frmUsedelegatetohandleevents_Load);
            this.ResumeLayout(false);

        }

        private void frmUsedelegatetohandleevents_Load(object sender, EventArgs e)
        {

        }
    }
}
