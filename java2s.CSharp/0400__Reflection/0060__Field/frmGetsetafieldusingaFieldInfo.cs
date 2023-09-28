using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0060__Field
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetsetafieldusingaFieldInfo.htm
    public partial  class frmGetsetafieldusingaFieldInfo:Form
    {
        public frmGetsetafieldusingaFieldInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetsetafieldusingaFieldInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetsetafieldusingaFieldInfo";
            this.Text = "frmGetsetafieldusingaFieldInfo";
            this.Load += new System.EventHandler(this.frmGetsetafieldusingaFieldInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmGetsetafieldusingaFieldInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
