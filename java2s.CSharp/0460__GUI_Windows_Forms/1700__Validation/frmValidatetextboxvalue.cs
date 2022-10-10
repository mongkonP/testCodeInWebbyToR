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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Validatetextboxvalue.htm
    public partial  class frmValidatetextboxvalue:Form
    {
        public frmValidatetextboxvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmValidatetextboxvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmValidatetextboxvalue";
            this.Text = "frmValidatetextboxvalue";
            this.Load += new System.EventHandler(this.frmValidatetextboxvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmValidatetextboxvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
