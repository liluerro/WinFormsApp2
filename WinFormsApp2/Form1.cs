namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int[] numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numbers = new int[10];  

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(-10, 11); 

            label1.Text = string.Join(" ", numbers);
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Спочатку згенеруйте масив!");
                return;
            }

            int? firstPositive = numbers.FirstOrDefault(x => x > 0);
            if (firstPositive <= 0) firstPositive = null;

            int? lastNegative = numbers.Reverse().FirstOrDefault(x => x < 0);
            if (lastNegative >= 0) lastNegative = null;

            if (firstPositive.HasValue && lastNegative.HasValue)
            {
                int result = firstPositive.Value - lastNegative.Value;
                label3.Text = result.ToString();
            }
            else
            {
                label3.Text = "Немає потрібних елементів!";
            }
        }
    }
}
