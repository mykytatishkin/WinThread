namespace WinThread
{
    public partial class Form1 : Form
    {
        Thread? firstThread;
        Thread? secondThread;
        public Form1()
        {
            InitializeComponent();
            firstThread = new Thread(TestMethod);
            secondThread = new Thread(TestMethod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstThread.Start("First");
            }
            catch
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { 
                secondThread.Start("\t\tSecond");
            }
            catch
            {

            }
        }
        void TestMethod(object? param)
        {
            for(int i = 0; i < 100; i++)
            {
                listBox1.Items.Add($"{param}: {i+1}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
                Thread.Sleep(100);
            }
        }
    }
}