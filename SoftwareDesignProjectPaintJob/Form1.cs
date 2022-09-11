namespace SoftwareDesignProjectPaintJob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCeilingSF_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCeilingRate_Click(object sender, EventArgs e)
        {

        }

        private void lblCeilingSF_Click(object sender, EventArgs e)
        {

        }

        private void txtCeilingRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClicktoCalculate_Click(object sender, EventArgs e)
        {
            decimal ceilingLength = Convert.ToDecimal(txtCeilingLength.Text);
            decimal ceilingWidth = Convert.ToDecimal(txtCeilingWidth.Text);
            decimal ceilingRate = Convert.ToDecimal(txtCeilingRate.Text);   
            decimal result1 = ceilingLength * ceilingWidth;
            decimal result2 = result1 * ceilingRate;

            txtCeilingSF.Text = Convert.ToString(result1);
            txtCeilingEstimateTotal.Text = Convert.ToString(result2);
        }

        private void txtCeilingEstimateTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}