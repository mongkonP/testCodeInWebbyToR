using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/TheGeneralFormofaClass.htm
    public partial  class frmTheGeneralFormofaClass:Form
    {
        public frmTheGeneralFormofaClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheGeneralFormofaClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheGeneralFormofaClass";
            this.Text = "frmTheGeneralFormofaClass";
            this.Load += new System.EventHandler(this.frmTheGeneralFormofaClass_Load);
            this.ResumeLayout(false);

        }

        private void frmTheGeneralFormofaClass_Load(object sender, EventArgs e)
        {

        }
    }
}
