using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0040__Switch
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Emptycasescanfallthrough.htm
    public partial  class frmEmptycasescanfallthrough:Form
    {
        public frmEmptycasescanfallthrough()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmptycasescanfallthrough
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmptycasescanfallthrough";
            this.Text = "frmEmptycasescanfallthrough";
            this.Load += new System.EventHandler(this.frmEmptycasescanfallthrough_Load);
            this.ResumeLayout(false);

        }

        private void frmEmptycasescanfallthrough_Load(object sender, EventArgs e)
        {

        }
    }
}