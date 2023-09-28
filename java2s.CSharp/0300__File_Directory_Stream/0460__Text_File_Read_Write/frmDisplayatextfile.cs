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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Displayatextfile.htm
    public partial  class frmDisplayatextfile:Form
    {
        public frmDisplayatextfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayatextfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayatextfile";
            this.Text = "frmDisplayatextfile";
            this.Load += new System.EventHandler(this.frmDisplayatextfile_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayatextfile_Load(object sender, EventArgs e)
        {

        }
    }
}
