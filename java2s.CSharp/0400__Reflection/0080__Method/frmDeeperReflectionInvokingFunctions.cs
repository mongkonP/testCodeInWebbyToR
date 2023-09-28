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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/DeeperReflectionInvokingFunctions.htm
    public partial  class frmDeeperReflectionInvokingFunctions:Form
    {
        public frmDeeperReflectionInvokingFunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeeperReflectionInvokingFunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeeperReflectionInvokingFunctions";
            this.Text = "frmDeeperReflectionInvokingFunctions";
            this.Load += new System.EventHandler(this.frmDeeperReflectionInvokingFunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmDeeperReflectionInvokingFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
