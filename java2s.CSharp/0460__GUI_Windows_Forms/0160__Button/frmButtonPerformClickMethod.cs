using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ButtonPerformClickMethod.htm
    public partial  class frmButtonPerformClickMethod:Form
    {
        public frmButtonPerformClickMethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonPerformClickMethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonPerformClickMethod";
            this.Text = "frmButtonPerformClickMethod";
            this.Load += new System.EventHandler(this.frmButtonPerformClickMethod_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonPerformClickMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
