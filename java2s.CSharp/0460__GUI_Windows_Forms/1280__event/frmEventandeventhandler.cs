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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Eventandeventhandler.htm
    public partial  class frmEventandeventhandler:Form
    {
        public frmEventandeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventandeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventandeventhandler";
            this.Text = "frmEventandeventhandler";
            this.Load += new System.EventHandler(this.frmEventandeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmEventandeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
