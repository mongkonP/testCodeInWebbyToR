using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/BasicStringfunctionality.htm
    public partial  class frmBasicStringfunctionality:Form
    {
        public frmBasicStringfunctionality()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBasicStringfunctionality
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBasicStringfunctionality";
            this.Text = "frmBasicStringfunctionality";
            this.Load += new System.EventHandler(this.frmBasicStringfunctionality_Load);
            this.ResumeLayout(false);

        }

        private void frmBasicStringfunctionality_Load(object sender, EventArgs e)
        {

        }
    }
}
