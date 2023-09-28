using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0660__HeaderedItemsControl
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ExpanderHeader.htm
    public partial  class frmExpanderHeader:Form
    {
        public frmExpanderHeader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExpanderHeader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExpanderHeader";
            this.Text = "frmExpanderHeader";
            this.Load += new System.EventHandler(this.frmExpanderHeader_Load);
            this.ResumeLayout(false);

        }

        private void frmExpanderHeader_Load(object sender, EventArgs e)
        {

        }
    }
}
