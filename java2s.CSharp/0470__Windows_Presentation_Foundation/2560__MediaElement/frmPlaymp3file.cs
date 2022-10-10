using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2560__MediaElement
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Playmp3file.htm
    public partial  class frmPlaymp3file:Form
    {
        public frmPlaymp3file()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlaymp3file
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlaymp3file";
            this.Text = "frmPlaymp3file";
            this.Load += new System.EventHandler(this.frmPlaymp3file_Load);
            this.ResumeLayout(false);

        }

        private void frmPlaymp3file_Load(object sender, EventArgs e)
        {

        }
    }
}
