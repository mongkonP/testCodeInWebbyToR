using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Getsetpropertyusinginvokemember.htm
    public partial  class frmGetsetpropertyusinginvokemember:Form
    {
        public frmGetsetpropertyusinginvokemember()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetsetpropertyusinginvokemember
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetsetpropertyusinginvokemember";
            this.Text = "frmGetsetpropertyusinginvokemember";
            this.Load += new System.EventHandler(this.frmGetsetpropertyusinginvokemember_Load);
            this.ResumeLayout(false);

        }

        private void frmGetsetpropertyusinginvokemember_Load(object sender, EventArgs e)
        {

        }
    }
}
