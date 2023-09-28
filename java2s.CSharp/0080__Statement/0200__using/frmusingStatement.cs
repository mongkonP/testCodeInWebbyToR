using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0200__using
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/usingStatement.htm
    public partial  class frmusingStatement:Form
    {
        public frmusingStatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmusingStatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmusingStatement";
            this.Text = "frmusingStatement";
            this.Load += new System.EventHandler(this.frmusingStatement_Load);
            this.ResumeLayout(false);

        }

        private void frmusingStatement_Load(object sender, EventArgs e)
        {

        }
    }
}
