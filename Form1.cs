namespace Lecture5LoopsEtc
{
    public partial class Form1 : Form
    {

        int data2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            //get the data from the text box using in.tryParse
            int data1 = 0;
            int.TryParse(txtData1.Text, out data1);

            //create a counter that starts at 1
            int count = 1;

            //while the counter is less than the number you are testing
            //testing is done BEFORE you run the loop
            while (count < data1)
            {
                //show on the listbox
                lbxLoop.Items.Add("While " + count + " X " + data1 + " = " + (data1 * count));

                //increase the counter by 1
                count++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            //get the data from the text box using in.tryParse
            int data1 = 0;
            int.TryParse(txtData1.Text, out data1);

            //create a counter that starts at 1
            int count = 1;

            //while the counter is less than the number you are testing
            //testing is done BEFORE you run the loop
            do
            {
                //show on the listbox
                lbxLoop.Items.Add("Do While " + count + " X " + data1 + " = " + (data1 * count));

                //increase the counter by 1
                count++;
            } while (count < data1);

        }
    }
}
