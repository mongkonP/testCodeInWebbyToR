using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0040__Switch
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/TheswitchStatement.htm
    public partial  class frmTheswitchStatement:Form
    {
        public frmTheswitchStatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheswitchStatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheswitchStatement";
            this.Text = "frmTheswitchStatement";
            this.Load += new System.EventHandler(this.frmTheswitchStatement_Load);
            this.ResumeLayout(false);

        }

        private void frmTheswitchStatement_Load(object sender, EventArgs e)
        {

        }
    }
}
