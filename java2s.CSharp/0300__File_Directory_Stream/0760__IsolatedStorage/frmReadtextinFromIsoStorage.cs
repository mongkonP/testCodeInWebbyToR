using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0760__IsolatedStorage
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ReadtextinFromIsoStorage.htm
    public partial  class frmReadtextinFromIsoStorage:Form
    {
        public frmReadtextinFromIsoStorage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadtextinFromIsoStorage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadtextinFromIsoStorage";
            this.Text = "frmReadtextinFromIsoStorage";
            this.Load += new System.EventHandler(this.frmReadtextinFromIsoStorage_Load);
            this.ResumeLayout(false);

        }

        private void frmReadtextinFromIsoStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
