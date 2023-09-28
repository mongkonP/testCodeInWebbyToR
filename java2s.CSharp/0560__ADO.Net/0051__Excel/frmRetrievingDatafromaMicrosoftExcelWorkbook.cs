using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0051__Excel
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RetrievingDatafromaMicrosoftExcelWorkbook.htm
    public partial  class frmRetrievingDatafromaMicrosoftExcelWorkbook:Form
    {
        public frmRetrievingDatafromaMicrosoftExcelWorkbook()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingDatafromaMicrosoftExcelWorkbook
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingDatafromaMicrosoftExcelWorkbook";
            this.Text = "frmRetrievingDatafromaMicrosoftExcelWorkbook";
            this.Load += new System.EventHandler(this.frmRetrievingDatafromaMicrosoftExcelWorkbook_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingDatafromaMicrosoftExcelWorkbook_Load(object sender, EventArgs e)
        {

        }
    }
}
