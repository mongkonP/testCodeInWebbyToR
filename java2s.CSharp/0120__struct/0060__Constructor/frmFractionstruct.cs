using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0060__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Fractionstruct.htm
    public partial  class frmFractionstruct:Form
    {
        public frmFractionstruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFractionstruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFractionstruct";
            this.Text = "frmFractionstruct";
            this.Load += new System.EventHandler(this.frmFractionstruct_Load);
            this.ResumeLayout(false);

        }

        private void frmFractionstruct_Load(object sender, EventArgs e)
        {

        }
    }
}
