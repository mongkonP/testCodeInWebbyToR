using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0100__Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Analyzemethodparametersusingreflection.htm
    public partial  class frmAnalyzemethodparametersusingreflection:Form
    {
        public frmAnalyzemethodparametersusingreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnalyzemethodparametersusingreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnalyzemethodparametersusingreflection";
            this.Text = "frmAnalyzemethodparametersusingreflection";
            this.Load += new System.EventHandler(this.frmAnalyzemethodparametersusingreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmAnalyzemethodparametersusingreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
