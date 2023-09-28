using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0820__CSV_File
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Readcsvfileandcreateobjectfromit.htm
    public partial  class frmReadcsvfileandcreateobjectfromit:Form
    {
        public frmReadcsvfileandcreateobjectfromit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadcsvfileandcreateobjectfromit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadcsvfileandcreateobjectfromit";
            this.Text = "frmReadcsvfileandcreateobjectfromit";
            this.Load += new System.EventHandler(this.frmReadcsvfileandcreateobjectfromit_Load);
            this.ResumeLayout(false);

        }

        private void frmReadcsvfileandcreateobjectfromit_Load(object sender, EventArgs e)
        {

        }
    }
}
