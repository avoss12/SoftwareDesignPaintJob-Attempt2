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
            decimal itemLength = Convert.ToDecimal(txtItemLength.Text);
            decimal itemWidthHeight = Convert.ToDecimal(txtItemWidthHeight.Text);
            decimal itemRate = Convert.ToDecimal(txtItemRate.Text);   
            decimal itemSF = itemLength * itemWidthHeight;
            decimal result2 = itemSF * itemRate;

            txtItemSF.Text = Convert.ToString(itemSF);
            txtItemEstTotal.Text = Convert.ToString(result2);
            txtRoomName.Text = itemNameList.Text;

            Ceilings newCeiling = new Ceilings(itemNameList.Text, txtItemPaintColor.Text, itemLength, itemWidthHeight, itemSF);

            Type thisType = newCeiling.GetType();
            txtThisType.Text = thisType.Name.ToString();

            item_class obj_item_iclass = new item_class();
            obj_item_iclass.doCalc(itemLength, itemWidthHeight, itemRate);
            txtInterfaceEstimate.Text = obj_item_iclass.itemEstTotal.ToString();

        }

        private void txtCeilingEstimateTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThisType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}