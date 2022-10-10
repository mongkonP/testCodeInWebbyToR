using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0660__Using_Statement
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Useobjectinsideusingstatement.htm
    public partial  class frmUseobjectinsideusingstatement:Form
    {
        public frmUseobjectinsideusingstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseobjectinsideusingstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseobjectinsideusingstatement";
            this.Text = "frmUseobjectinsideusingstatement";
            this.Load += new System.EventHandler(this.frmUseobjectinsideusingstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmUseobjectinsideusingstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
