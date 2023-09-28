using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0180__File_Access_Mode
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Createsafilewithreadwriteaccessthatallowsotherstoread.htm
    public partial  class frmCreatesafilewithreadwriteaccessthatallowsotherstoread:Form
    {
        public frmCreatesafilewithreadwriteaccessthatallowsotherstoread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatesafilewithreadwriteaccessthatallowsotherstoread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatesafilewithreadwriteaccessthatallowsotherstoread";
            this.Text = "frmCreatesafilewithreadwriteaccessthatallowsotherstoread";
            this.Load += new System.EventHandler(this.frmCreatesafilewithreadwriteaccessthatallowsotherstoread_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatesafilewithreadwriteaccessthatallowsotherstoread_Load(object sender, EventArgs e)
        {

        }
    }
}
