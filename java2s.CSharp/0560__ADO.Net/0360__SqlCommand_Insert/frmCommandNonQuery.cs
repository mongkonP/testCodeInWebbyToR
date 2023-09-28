using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0360__SqlCommand_Insert
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CommandNonQuery.htm
    public partial  class frmCommandNonQuery:Form
    {
        public frmCommandNonQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommandNonQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommandNonQuery";
            this.Text = "frmCommandNonQuery";
            this.Load += new System.EventHandler(this.frmCommandNonQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmCommandNonQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
