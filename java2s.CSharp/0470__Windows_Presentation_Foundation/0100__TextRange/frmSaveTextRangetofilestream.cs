using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0100__TextRange
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SaveTextRangetofilestream.htm
    public partial  class frmSaveTextRangetofilestream:Form
    {
        public frmSaveTextRangetofilestream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveTextRangetofilestream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveTextRangetofilestream";
            this.Text = "frmSaveTextRangetofilestream";
            this.Load += new System.EventHandler(this.frmSaveTextRangetofilestream_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveTextRangetofilestream_Load(object sender, EventArgs e)
        {

        }
    }
}
