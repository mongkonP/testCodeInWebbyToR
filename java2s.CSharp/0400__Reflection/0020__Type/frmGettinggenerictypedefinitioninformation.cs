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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Gettinggenerictypedefinitioninformation.htm
    public partial  class frmGettinggenerictypedefinitioninformation:Form
    {
        public frmGettinggenerictypedefinitioninformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettinggenerictypedefinitioninformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettinggenerictypedefinitioninformation";
            this.Text = "frmGettinggenerictypedefinitioninformation";
            this.Load += new System.EventHandler(this.frmGettinggenerictypedefinitioninformation_Load);
            this.ResumeLayout(false);

        }

        private void frmGettinggenerictypedefinitioninformation_Load(object sender, EventArgs e)
        {

        }
    }
}
