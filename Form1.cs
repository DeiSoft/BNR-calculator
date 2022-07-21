namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pr_textBox.Text = "5";
            am_textBox.Text = "12";
        }

        //decimal moneyEc = 0;

        decimal total = 0;
        int click = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            decimal calc = (Convert.ToDecimal(pr_textBox.Text)/100)*Convert.ToDecimal(am_textBox.Text);
            total = calc + Convert.ToDecimal(am_textBox.Text);

            sum_text.Text = $"{calc}";

            //total
            txt_monthMoney.Text = $"{12 + total}";
            txt_total.Text = $"{total}";

            am_textBox.Text = txt_monthMoney.Text;

            click++;
            txt_click.Text = $"{click}";
        }
    }
}