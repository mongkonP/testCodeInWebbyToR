using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Displaytheprocessstatisticsuntiltheuserclosestheprogram.htm
    public partial  class frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram:Form
    {
        public frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram";
            this.Text = "frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram";
            this.Load += new System.EventHandler(this.frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaytheprocessstatisticsuntiltheuserclosestheprogram_Load(object sender, EventArgs e)
        {

        }
    }
}
