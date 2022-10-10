using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0460__Text_File_Read_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Readtextfilelinebyline.htm
    public partial  class frmReadtextfilelinebyline:Form
    {
        public frmReadtextfilelinebyline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadtextfilelinebyline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadtextfilelinebyline";
            this.Text = "frmReadtextfilelinebyline";
            this.Load += new System.EventHandler(this.frmReadtextfilelinebyline_Load);
            this.ResumeLayout(false);

        }

        private void frmReadtextfilelinebyline_Load(object sender, EventArgs e)
        {

        }
    }
}
