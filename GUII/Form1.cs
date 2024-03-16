using Ogrodnik_lab1;

namespace GUII
{
    public partial class BagpackApplication : Form
    {
        public BagpackApplication()
        {
            InitializeComponent();
        }

        private void solev_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(capacity_box.Text) || string.IsNullOrEmpty(numberOfElements.Text) || string.IsNullOrEmpty(seed_box.Text))
            {
                MessageBox.Show("Enter all values!!!");
                return;
            }
            Progress.Value = 0;
            var capacity = Int32.Parse(capacity_box.Text);
            var seed = Int32.Parse(seed_box.Text);
            var number = Int32.Parse(numberOfElements.Text);
            Progress.Value += 25;

            var problem = new Problem(number, seed);
            var problem_instance_text = problem.ToString().Replace("\n", Environment.NewLine);
            problem_boox.Text = problem_instance_text;
            Progress.Value += 25;
            var result = problem.Solve(capacity);
            Progress.Value += 25;

            if (result.ToString() == "")
            {
                result_boox.Text = "No item has been selected";
                return;
            }
            var result_text = result.ToString().Replace("\n", Environment.NewLine);
            Progress.Value += 25;
            result_boox.Text = result_text;

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            problem_boox.Clear();
            result_boox.Clear();
            Progress.Value = 0;
        }


        private void numberOfElements_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(numberOfElements.Text, out result) || string.IsNullOrEmpty(numberOfElements.Text))
            {
                numberOfElements.ForeColor = Color.Red;
                solev_button.Enabled = false;
            }
            else
            {
                numberOfElements.ForeColor = Color.Black;
                solev_button.Enabled = true;
            }

        }

        private void seed_box_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(seed_box.Text, out result) || string.IsNullOrEmpty(seed_box.Text))
            {
                seed_box.ForeColor = Color.Red;
                solev_button.Enabled = false;
            }
            else
            {
                seed_box.ForeColor = Color.Black;
                solev_button.Enabled = true;
            }
        }

        private void capacity_box_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(capacity_box.Text, out result) || string.IsNullOrEmpty(capacity_box.Text))
            {
                capacity_box.ForeColor = Color.Red;
                solev_button.Enabled = false;
            }
            else
            {
                capacity_box.ForeColor = Color.Black;
                solev_button.Enabled = true;
            }
        }








        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}