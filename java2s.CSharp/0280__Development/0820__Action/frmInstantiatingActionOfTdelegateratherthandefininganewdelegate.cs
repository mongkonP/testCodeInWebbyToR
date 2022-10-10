using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0820__Action
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/InstantiatingActionOfTdelegateratherthandefininganewdelegate.htm
    public partial  class frmInstantiatingActionOfTdelegateratherthandefininganewdelegate:Form
    {
        public frmInstantiatingActionOfTdelegateratherthandefininganewdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInstantiatingActionOfTdelegateratherthandefininganewdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInstantiatingActionOfTdelegateratherthandefininganewdelegate";
            this.Text = "frmInstantiatingActionOfTdelegateratherthandefininganewdelegate";
            this.Load += new System.EventHandler(this.frmInstantiatingActionOfTdelegateratherthandefininganewdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmInstantiatingActionOfTdelegateratherthandefininganewdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
