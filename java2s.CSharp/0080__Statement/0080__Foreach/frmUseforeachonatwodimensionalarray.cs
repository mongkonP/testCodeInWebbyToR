using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0080__Foreach
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Useforeachonatwodimensionalarray.htm
    public partial  class frmUseforeachonatwodimensionalarray:Form
    {
        public frmUseforeachonatwodimensionalarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseforeachonatwodimensionalarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseforeachonatwodimensionalarray";
            this.Text = "frmUseforeachonatwodimensionalarray";
            this.Load += new System.EventHandler(this.frmUseforeachonatwodimensionalarray_Load);
            this.ResumeLayout(false);

        }

        private void frmUseforeachonatwodimensionalarray_Load(object sender, EventArgs e)
        {

        }
    }
}
