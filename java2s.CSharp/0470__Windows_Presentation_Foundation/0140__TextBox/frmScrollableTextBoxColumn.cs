using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0140__TextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ScrollableTextBoxColumn.htm
    public partial  class frmScrollableTextBoxColumn:Form
    {
        public frmScrollableTextBoxColumn()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScrollableTextBoxColumn
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScrollableTextBoxColumn";
            this.Text = "frmScrollableTextBoxColumn";
            this.Load += new System.EventHandler(this.frmScrollableTextBoxColumn_Load);
            this.ResumeLayout(false);

        }

        private void frmScrollableTextBoxColumn_Load(object sender, EventArgs e)
        {

        }
    }
}
