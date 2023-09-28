using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0960__DataBinding_ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/FillListBoxwithdatafromaDataReader.htm
    public partial  class frmFillListBoxwithdatafromaDataReader:Form
    {
        public frmFillListBoxwithdatafromaDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillListBoxwithdatafromaDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillListBoxwithdatafromaDataReader";
            this.Text = "frmFillListBoxwithdatafromaDataReader";
            this.Load += new System.EventHandler(this.frmFillListBoxwithdatafromaDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmFillListBoxwithdatafromaDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
