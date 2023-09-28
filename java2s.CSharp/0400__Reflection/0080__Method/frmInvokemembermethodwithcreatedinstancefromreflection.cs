using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Invokemembermethodwithcreatedinstancefromreflection.htm
    public partial  class frmInvokemembermethodwithcreatedinstancefromreflection:Form
    {
        public frmInvokemembermethodwithcreatedinstancefromreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokemembermethodwithcreatedinstancefromreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokemembermethodwithcreatedinstancefromreflection";
            this.Text = "frmInvokemembermethodwithcreatedinstancefromreflection";
            this.Load += new System.EventHandler(this.frmInvokemembermethodwithcreatedinstancefromreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokemembermethodwithcreatedinstancefromreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
