using System.Diagnostics.Metrics;

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
            lbxLoop.Items.Add("W TimesTable " + data1 + " count " + count);
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
            lbxLoop.Items.Add("DW TimesTable " + data1 + " count " + count);

        }

        private void lbxLoop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxLoop.Items.Clear();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //get the data from the text box using in.tryParse
            int data1 = 0;
            int.TryParse(txtData1.Text, out data1);
            int count = 0;
            //Create a random number Generator
            //we take the existing class and make a new instance of it.
            Random random = new Random(DateTime.Now.Millisecond);
            //set the rang of the data from 1 to include 6
            int rand = random.Next(1, 7);

            while (rand != data1)
            {
                //generate a new random number in the loop
                rand = random.Next(1, 7);
                count++;
                //show on the listbox
                lbxLoop.Items.Add("While " + rand + " " + data1);

            }
            lbxLoop.Items.Add("While Match count of " + count + " rand " + rand + " input " + data1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the data from the text box using in.tryParse
            int data1 = 0;
            int.TryParse(txtData1.Text, out data1);
            int count = 0;
            //Create a random number Generator
            //we take the existing class and make a new instance of it.
            Random random = new Random();
            //make a variable to hold your random number
            int rand = 0;
            do
            {
                //set the range of the data from 1 to include 6
                rand = random.Next(1, 7);
                count++;

                lbxLoop.Items.Add("Do " + rand + " " + data1);
            } while (rand != data1);
            lbxLoop.Items.Add("D TimesTable " + data1 + " count " + count);

        }
    }
}
