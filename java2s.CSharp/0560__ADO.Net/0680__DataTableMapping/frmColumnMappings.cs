using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0680__DataTableMapping
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ColumnMappings.htm
    public partial  class frmColumnMappings:Form
    {
        public frmColumnMappings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColumnMappings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColumnMappings";
            this.Text = "frmColumnMappings";
            this.Load += new System.EventHandler(this.frmColumnMappings_Load);
            this.ResumeLayout(false);

        }

        private void frmColumnMappings_Load(object sender, EventArgs e)
        {

        }
    }
}
