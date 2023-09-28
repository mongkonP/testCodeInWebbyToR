using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0100__TimeSpan
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/TimeSpancalculation.htm
    public partial  class frmTimeSpancalculation:Form
    {
        public frmTimeSpancalculation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTimeSpancalculation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTimeSpancalculation";
            this.Text = "frmTimeSpancalculation";
            this.Load += new System.EventHandler(this.frmTimeSpancalculation_Load);
            this.ResumeLayout(false);

        }

        private void frmTimeSpancalculation_Load(object sender, EventArgs e)
        {

        }
    }
}
