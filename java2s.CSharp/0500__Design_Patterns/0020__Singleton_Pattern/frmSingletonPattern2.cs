using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0020__Singleton_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/SingletonPattern2.htm
    public partial  class frmSingletonPattern2:Form
    {
        private RichTextBox richTextBox1;

        public frmSingletonPattern2()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmSingletonPattern2
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmSingletonPattern2";
            this.Text = "frmSingletonPattern2";
            this.Load += new System.EventHandler(this.frmSingletonPattern2_Load);
            this.ResumeLayout(false);

        }

        private void frmSingletonPattern2_Load(object sender, EventArgs e)
        {
            try
            {
                Engine eng = Engine.GetEngine();
            }
            catch (Exception _e)
            {
                richTextBox1 .WriteLine(_e.Message);
            }

            try
            {
                Engine eng = Engine.GetEngine();
            }
            catch (Exception __e)
            {
                richTextBox1.WriteLine(__e.Message);
            }
        }
        sealed class Engine
        {
            private static bool instanceFlag = false;
            public static Engine GetEngine()
            {
                if (!instanceFlag)
                {
                    instanceFlag = true;
                    return new Engine();
                }
                else
                {
                    throw new Exception("An engine has already been created!");
                }
            }
            private Engine()
            {
                Console.WriteLine("An Engine");
            }
        }
    }
}
