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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ReflectingOnMembersOfAType.htm
    public partial  class frmReflectingOnMembersOfAType:Form
    {
        public frmReflectingOnMembersOfAType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectingOnMembersOfAType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectingOnMembersOfAType";
            this.Text = "frmReflectingOnMembersOfAType";
            this.Load += new System.EventHandler(this.frmReflectingOnMembersOfAType_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectingOnMembersOfAType_Load(object sender, EventArgs e)
        {

        }
    }
}
