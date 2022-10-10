using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1000__Print_Preview_Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OutputthePrinterSettingsinformation.htm
    public partial  class frmOutputthePrinterSettingsinformation:Form
    {
        public frmOutputthePrinterSettingsinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOutputthePrinterSettingsinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOutputthePrinterSettingsinformation";
            this.Text = "frmOutputthePrinterSettingsinformation";
            this.Load += new System.EventHandler(this.frmOutputthePrinterSettingsinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmOutputthePrinterSettingsinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
