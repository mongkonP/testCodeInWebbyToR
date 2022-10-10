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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/SimpleIOwiththeFileType.htm
    public partial  class frmSimpleIOwiththeFileType:Form
    {
        public frmSimpleIOwiththeFileType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleIOwiththeFileType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleIOwiththeFileType";
            this.Text = "frmSimpleIOwiththeFileType";
            this.Load += new System.EventHandler(this.frmSimpleIOwiththeFileType_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleIOwiththeFileType_Load(object sender, EventArgs e)
        {

        }
    }
}
