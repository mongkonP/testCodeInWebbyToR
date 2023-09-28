using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0343__ListBox_Data
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DisplayBoundedobjectsontoListBox.htm
    public partial  class frmDisplayBoundedobjectsontoListBox:Form
    {
        public frmDisplayBoundedobjectsontoListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayBoundedobjectsontoListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayBoundedobjectsontoListBox";
            this.Text = "frmDisplayBoundedobjectsontoListBox";
            this.Load += new System.EventHandler(this.frmDisplayBoundedobjectsontoListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayBoundedobjectsontoListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
