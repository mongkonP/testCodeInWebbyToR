using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0160__Interface
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReturnTypeInference.htm
    public partial  class frmReturnTypeInference:Form
    {
        public frmReturnTypeInference()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnTypeInference
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnTypeInference";
            this.Text = "frmReturnTypeInference";
            this.Load += new System.EventHandler(this.frmReturnTypeInference_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnTypeInference_Load(object sender, EventArgs e)
        {

        }
    }
}
