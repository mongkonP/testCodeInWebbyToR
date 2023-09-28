using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0360__Stream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Usingstreamreadertoreadtheentirestreamatonce.htm
    public partial  class frmUsingstreamreadertoreadtheentirestreamatonce:Form
    {
        public frmUsingstreamreadertoreadtheentirestreamatonce()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingstreamreadertoreadtheentirestreamatonce
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingstreamreadertoreadtheentirestreamatonce";
            this.Text = "frmUsingstreamreadertoreadtheentirestreamatonce";
            this.Load += new System.EventHandler(this.frmUsingstreamreadertoreadtheentirestreamatonce_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingstreamreadertoreadtheentirestreamatonce_Load(object sender, EventArgs e)
        {

        }
    }
}
