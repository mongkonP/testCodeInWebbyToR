using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1700__Validation
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Validationcallback.htm
    public partial  class frmValidationcallback:Form
    {
        public frmValidationcallback()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValidationcallback
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValidationcallback";
            this.Text = "frmValidationcallback";
            this.Load += new System.EventHandler(this.frmValidationcallback_Load);
            this.ResumeLayout(false);

        }

        private void frmValidationcallback_Load(object sender, EventArgs e)
        {

        }
    }
}
