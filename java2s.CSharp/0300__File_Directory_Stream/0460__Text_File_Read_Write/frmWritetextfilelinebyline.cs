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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Writetextfilelinebyline.htm
    public partial  class frmWritetextfilelinebyline:Form
    {
        public frmWritetextfilelinebyline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritetextfilelinebyline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritetextfilelinebyline";
            this.Text = "frmWritetextfilelinebyline";
            this.Load += new System.EventHandler(this.frmWritetextfilelinebyline_Load);
            this.ResumeLayout(false);

        }

        private void frmWritetextfilelinebyline_Load(object sender, EventArgs e)
        {

        }
    }
}
