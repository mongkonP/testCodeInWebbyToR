using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1140__nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/AgeCalculationwithnullabledeathdate.htm
    public partial  class frmAgeCalculationwithnullabledeathdate:Form
    {
        public frmAgeCalculationwithnullabledeathdate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAgeCalculationwithnullabledeathdate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAgeCalculationwithnullabledeathdate";
            this.Text = "frmAgeCalculationwithnullabledeathdate";
            this.Load += new System.EventHandler(this.frmAgeCalculationwithnullabledeathdate_Load);
            this.ResumeLayout(false);

        }

        private void frmAgeCalculationwithnullabledeathdate_Load(object sender, EventArgs e)
        {

        }
    }
}
