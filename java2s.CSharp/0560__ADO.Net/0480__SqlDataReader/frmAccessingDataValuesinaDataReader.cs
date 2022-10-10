using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0480__SqlDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AccessingDataValuesinaDataReader.htm
    public partial  class frmAccessingDataValuesinaDataReader:Form
    {
        public frmAccessingDataValuesinaDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingDataValuesinaDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingDataValuesinaDataReader";
            this.Text = "frmAccessingDataValuesinaDataReader";
            this.Load += new System.EventHandler(this.frmAccessingDataValuesinaDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingDataValuesinaDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
