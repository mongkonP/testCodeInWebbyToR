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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Invokemethodsusingreflection.htm
    public partial  class frmInvokemethodsusingreflection:Form
    {
        public frmInvokemethodsusingreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokemethodsusingreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokemethodsusingreflection";
            this.Text = "frmInvokemethodsusingreflection";
            this.Load += new System.EventHandler(this.frmInvokemethodsusingreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokemethodsusingreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
