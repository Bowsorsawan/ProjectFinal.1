namespace โปรเจคWinFormsApp2.s
{
    public partial class Form1 : Form
    {
        int order = 1;
        double total = 0;
        private object obj;
        private object receiptBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                addRow(txtProductNane.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text);


                bool numTest;

                double num1 = Convert.ToDouble(txtQuantity.Text);
                double num2 = Convert.ToDouble(txtPrice.Text);
                double num3 = 0;
                double num4 = 0;
                numTest = Double.TryParse(txtTotal.Text, out num4);
                if (!numTest)
                {
                    num3 += num1 * num2;
                    txtTotal.Text = num3.ToString();
                }
                else if (numTest)
                {
                    num3 += num1 * num2;
                    num3 += num4;
                    txtTotal.Text = num3.ToString();
                }
                //addRow(txtProductNane.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text);

                //txtProductNane.Text = "";
                //txtQuantity.Text = "";
                //txtPrice.Text = "";
                //txtTotal.Text = "";
            }
            void addRow(string ID, string ProductName, string Price, string Total)
            {
                String[] row = {ID, ProductName,Price,Total};
                dataGridView1.Rows.Add(row);
            }
        }

        private void addRow(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        private void addRow(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txtProductNane.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                loadProductFromFile(file);
            }
        }

        private void loadProductFromFile(string Npath)
        {
            string[] lines = System.IO.File.ReadAllLines(Npath);
            if (lines.Length > 0)
            {

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.ShowDialog();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}