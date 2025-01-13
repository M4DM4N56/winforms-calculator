namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        public double num1;
        public double num2;
        public string operation = "";

        public double result;

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void display_box_TextChanged(object sender, EventArgs e) {

        }

        private void btn_one_Click(object sender, EventArgs e) {
            display_box.Text += "1";
        }

        private void btn_two_Click(object sender, EventArgs e) {
            display_box.Text += "2";
        }

        private void btn_three_Click(object sender, EventArgs e) {
            display_box.Text += "3";
        }

        private void btn_four_Click(object sender, EventArgs e) {
            display_box.Text += "4";
        }

        private void btn_five_Click(object sender, EventArgs e) {
            display_box.Text += "5";
        }

        private void btn_six_Click(object sender, EventArgs e) {
            display_box.Text += "6";
        }

        private void btn_seven_Click(object sender, EventArgs e) {
            display_box.Text += "7";
        }


        private void btn_eight_Click(object sender, EventArgs e) {
            display_box.Text += "8";
        }


        private void btn_nine_Click(object sender, EventArgs e) {
            display_box.Text += "9";
        }

        private void btn_zero_Click(object sender, EventArgs e) {
            display_box.Text += "0";
        }

        private void btn_decimal_Click(object sender, EventArgs e) {
            display_box.Text += ".";
        }

        private void btn_add_Click(object sender, EventArgs e) {
            num1 = double.Parse(display_box.Text);
            operation = "add";
            display_box.Text = "";
        }

        private void btn_subtract_Click(object sender, EventArgs e) {
            num1 = double.Parse(display_box.Text);
            operation = "subtract";
            display_box.Text = "";
        }

        private void btn_divide_Click(object sender, EventArgs e) {
            num1 = double.Parse(display_box.Text);
            operation = "divide";
            display_box.Text = "";
        }

        private void btn_multiply_Click(object sender, EventArgs e) {
            num1 = double.Parse(display_box.Text);
            operation = "multiply";
            display_box.Text = "";
        }

        private void btn_equals_Click(object sender, EventArgs e) {
            num2 = double.Parse(display_box.Text);

            if (operation == "add") { result = num1 + num2; }
            
            else if (operation == "subtract") { result = num1 - num2; }

            else if (operation == "multiply") { result = num1 * num2; }
            
            else if (operation == "divide") { result = num1 / num2; }

            display_box.Text = result.ToString();

        }
        private void btn_clear_Click(object sender, EventArgs e) {
            display_box.Text = "";
        }
    }
}