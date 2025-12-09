namespace Quiz04PracticeLOOPS_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void q4QuestionButton_Click(object sender, EventArgs e)
        {
            q4 q4 = new q4();
            q4.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 5; i++)
            {
                q1OutputLabel.Text += "GO BEARS GO! " + "\n";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 5)
            {
                q2OutputLabel.Text += "GO BEARS GO!" + "\n";
                i++;
            }

        }

        private void q2OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {



                int n = int.Parse(q3TextBox.Text);
                for (int i = 0; i < n; i++)
                {
                    q3OutputLabel.Text += "GO BEARS GO!" + "\n";

                }
            }
            catch { }
        }
    }
}
