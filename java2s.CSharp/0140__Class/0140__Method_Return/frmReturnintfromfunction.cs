using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0140__Method_Return
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Returnintfromfunction.htm
    public partial  class frmReturnintfromfunction:Form
    {
        public frmReturnintfromfunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnintfromfunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnintfromfunction";
            this.Text = "frmReturnintfromfunction";
            this.Load += new System.EventHandler(this.frmReturnintfromfunction_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnintfromfunction_Load(object sender, EventArgs e)
        {

        }
    }
}
