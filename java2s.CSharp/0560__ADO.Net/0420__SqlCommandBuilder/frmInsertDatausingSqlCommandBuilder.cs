using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0420__SqlCommandBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/InsertDatausingSqlCommandBuilder.htm
    public partial  class frmInsertDatausingSqlCommandBuilder:Form
    {
        public frmInsertDatausingSqlCommandBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertDatausingSqlCommandBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertDatausingSqlCommandBuilder";
            this.Text = "frmInsertDatausingSqlCommandBuilder";
            this.Load += new System.EventHandler(this.frmInsertDatausingSqlCommandBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertDatausingSqlCommandBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
