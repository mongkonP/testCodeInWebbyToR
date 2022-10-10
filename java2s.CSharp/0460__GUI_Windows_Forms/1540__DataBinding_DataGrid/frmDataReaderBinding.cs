using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1540__DataBinding_DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DataReaderBinding.htm
    public partial  class frmDataReaderBinding:Form
    {
        public frmDataReaderBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataReaderBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataReaderBinding";
            this.Text = "frmDataReaderBinding";
            this.Load += new System.EventHandler(this.frmDataReaderBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmDataReaderBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
