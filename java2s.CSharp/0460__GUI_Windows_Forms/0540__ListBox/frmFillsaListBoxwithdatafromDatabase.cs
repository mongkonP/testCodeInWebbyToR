using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0540__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FillsaListBoxwithdatafromDatabase.htm
    public partial  class frmFillsaListBoxwithdatafromDatabase:Form
    {
        public frmFillsaListBoxwithdatafromDatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillsaListBoxwithdatafromDatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillsaListBoxwithdatafromDatabase";
            this.Text = "frmFillsaListBoxwithdatafromDatabase";
            this.Load += new System.EventHandler(this.frmFillsaListBoxwithdatafromDatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmFillsaListBoxwithdatafromDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
