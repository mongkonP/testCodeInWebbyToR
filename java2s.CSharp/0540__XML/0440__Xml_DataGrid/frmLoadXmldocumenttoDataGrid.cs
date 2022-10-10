using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0440__Xml_DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/LoadXmldocumenttoDataGrid.htm
    public partial  class frmLoadXmldocumenttoDataGrid:Form
    {
        public frmLoadXmldocumenttoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadXmldocumenttoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadXmldocumenttoDataGrid";
            this.Text = "frmLoadXmldocumenttoDataGrid";
            this.Load += new System.EventHandler(this.frmLoadXmldocumenttoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadXmldocumenttoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
