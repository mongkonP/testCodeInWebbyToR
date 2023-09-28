using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1060__Control
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SetCaptiontitleoftheform.htm
    public partial  class frmSetCaptiontitleoftheform:Form
    {
        public frmSetCaptiontitleoftheform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetCaptiontitleoftheform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetCaptiontitleoftheform";
            this.Text = "frmSetCaptiontitleoftheform";
            this.Load += new System.EventHandler(this.frmSetCaptiontitleoftheform_Load);
            this.ResumeLayout(false);

        }

        private void frmSetCaptiontitleoftheform_Load(object sender, EventArgs e)
        {

        }
    }
}
