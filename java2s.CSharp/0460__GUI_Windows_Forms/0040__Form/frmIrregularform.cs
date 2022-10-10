using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Irregularform.htm
    public partial  class frmIrregularform:Form
    {
        public frmIrregularform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIrregularform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIrregularform";
            this.Text = "frmIrregularform";
            this.Load += new System.EventHandler(this.frmIrregularform_Load);
            this.ResumeLayout(false);

        }

        private void frmIrregularform_Load(object sender, EventArgs e)
        {

        }
    }
}
