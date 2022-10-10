using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangefonttoItalic.htm
    public partial  class frmChangefonttoItalic:Form
    {
        public frmChangefonttoItalic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangefonttoItalic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangefonttoItalic";
            this.Text = "frmChangefonttoItalic";
            this.Load += new System.EventHandler(this.frmChangefonttoItalic_Load);
            this.ResumeLayout(false);

        }

        private void frmChangefonttoItalic_Load(object sender, EventArgs e)
        {

        }
    }
}
