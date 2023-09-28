using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0720__Panel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/InserttoaPanelbyindex.htm
    public partial  class frmInserttoaPanelbyindex:Form
    {
        public frmInserttoaPanelbyindex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInserttoaPanelbyindex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInserttoaPanelbyindex";
            this.Text = "frmInserttoaPanelbyindex";
            this.Load += new System.EventHandler(this.frmInserttoaPanelbyindex_Load);
            this.ResumeLayout(false);

        }

        private void frmInserttoaPanelbyindex_Load(object sender, EventArgs e)
        {

        }
    }
}
