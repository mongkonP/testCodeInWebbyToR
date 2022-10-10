using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1020__Print_PrintDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/PrintPageSettingsMetrics.htm
    public partial  class frmPrintPageSettingsMetrics:Form
    {
        public frmPrintPageSettingsMetrics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintPageSettingsMetrics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintPageSettingsMetrics";
            this.Text = "frmPrintPageSettingsMetrics";
            this.Load += new System.EventHandler(this.frmPrintPageSettingsMetrics_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintPageSettingsMetrics_Load(object sender, EventArgs e)
        {

        }
    }
}
