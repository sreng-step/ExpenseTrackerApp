namespace ExpenseTrackerApp
{
    public partial class Form1 : Form
    {
        // hello
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using(var g = panel1.CreateGraphics())
            {
                g.FillEllipse(Brushes.White, 0,0,panel1.Width,panel1.Height);
            }
        }
    }
}
