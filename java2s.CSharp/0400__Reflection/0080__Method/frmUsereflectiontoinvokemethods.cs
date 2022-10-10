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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Usereflectiontoinvokemethods.htm
    public partial  class frmUsereflectiontoinvokemethods:Form
    {
        public frmUsereflectiontoinvokemethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsereflectiontoinvokemethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsereflectiontoinvokemethods";
            this.Text = "frmUsereflectiontoinvokemethods";
            this.Load += new System.EventHandler(this.frmUsereflectiontoinvokemethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUsereflectiontoinvokemethods_Load(object sender, EventArgs e)
        {

        }
    }
}
