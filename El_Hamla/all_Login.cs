using System;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class all_Login : Form
    {
        private CLStelegram _consoleManager;

        public all_Login()
        {

            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.all_Login_KeyDown);

            // إنشاء زر وتعيين موقعه على الصورة
            Button button1 = new Button();
            button1.Text = "Click Me";
            button1.Size = new Size(100, 50); // تعيين حجم الزر
            button1.Location = new Point(5000, 150); // تعيين موقع الزر داخل الصورة

            this.Controls.Add(button1); // إضافة الزر للنموذج
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLSusres use = new CLSusres();
            use.Log(textBox1.Text, textBox2.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _consoleManager = new CLStelegram();
            _consoleManager.RunConsoleApp();
        }

        private void all_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_consoleManager != null)
            {
                _consoleManager.StopConsoleApp();
            }
        }

        // إضافة حدث KeyDown للفورم
        private void all_Login_KeyDown(object sender, KeyEventArgs e)
        {
            // إذا تم الضغط على زر Enter (KeyCode 13) و التركيز على textBox2
            if (e.KeyCode == Keys.Enter && textBox2.Focused)
            {
                // نفذ نفس الكود الذي يتم تنفيذه عند الضغط على زر تسجيل الدخول
                button1.PerformClick();
            }
        }
        private void all_Login_Load(object sender, EventArgs e)
        {
            // تعيين حجم الأزرار والنصوص ثابتة
            button1.Width = 100; // تعيين عرض الزر
            button1.Height = 40; // تعيين ارتفاع الزر

            button2.Width = 100; // تعيين عرض الزر
            button2.Height = 40; // تعيين ارتفاع الزر

            textBox1.Width = 250; // تعيين عرض خانة النص
            textBox1.Height = 30; // تعيين ارتفاع خانة النص

            textBox2.Width = 250; // تعيين عرض خانة النص
            textBox2.Height = 30; // تعيين ارتفاع خانة النص
        }
    }
}
