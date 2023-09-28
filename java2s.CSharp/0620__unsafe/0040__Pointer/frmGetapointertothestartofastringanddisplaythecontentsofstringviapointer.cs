using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Getapointertothestartofastringanddisplaythecontentsofstringviapointer.htm
    public partial  class frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer:Form
    {
        public frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer";
            this.Text = "frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer";
            this.Load += new System.EventHandler(this.frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer_Load);
            this.ResumeLayout(false);

        }

        private void frmGetapointertothestartofastringanddisplaythecontentsofstringviapointer_Load(object sender, EventArgs e)
        {

        }
    }
}
