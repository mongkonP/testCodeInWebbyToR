using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0240__long_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/DividingaFloatbyZeroDisplayingNaN.htm
    public partial  class frmDividingaFloatbyZeroDisplayingNaN:Form
    {
        public frmDividingaFloatbyZeroDisplayingNaN()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDividingaFloatbyZeroDisplayingNaN
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDividingaFloatbyZeroDisplayingNaN";
            this.Text = "frmDividingaFloatbyZeroDisplayingNaN";
            this.Load += new System.EventHandler(this.frmDividingaFloatbyZeroDisplayingNaN_Load);
            this.ResumeLayout(false);

        }

        private void frmDividingaFloatbyZeroDisplayingNaN_Load(object sender, EventArgs e)
        {

        }
    }
}
