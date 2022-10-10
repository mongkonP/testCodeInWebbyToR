using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0100__Form_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormOpacitysetting.htm
    public partial  class frmFormOpacitysetting:Form
    {
        public frmFormOpacitysetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormOpacitysetting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormOpacitysetting";
            this.Text = "frmFormOpacitysetting";
            this.Load += new System.EventHandler(this.frmFormOpacitysetting_Load);
            this.ResumeLayout(false);

        }

        private void frmFormOpacitysetting_Load(object sender, EventArgs e)
        {

        }
    }
}
