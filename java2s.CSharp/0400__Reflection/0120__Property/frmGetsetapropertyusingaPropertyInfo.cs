using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0120__Property
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetsetapropertyusingaPropertyInfo.htm
    public partial  class frmGetsetapropertyusingaPropertyInfo:Form
    {
        public frmGetsetapropertyusingaPropertyInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetsetapropertyusingaPropertyInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetsetapropertyusingaPropertyInfo";
            this.Text = "frmGetsetapropertyusingaPropertyInfo";
            this.Load += new System.EventHandler(this.frmGetsetapropertyusingaPropertyInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmGetsetapropertyusingaPropertyInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
