using System.Diagnostics.Metrics;

using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            //get the data from the text box using in.tryParse
            int data1 = 0;
            int.TryParse(txtData1.Text, out data1);
            int count = 0;


            for (int i = 0; i <= data1; i++)
            {
                lbxLoop.Items.Add(" the i counter = " + i + " the match to stop " + data1);

            }


        }

        private void btnWritetofile_Click(object sender, EventArgs e)
        {
            //what is the name of your file
            string filePath = "file.txt";
            //get some data from a textbox
            string data1 = txtData1.Text;

            // Create a StreamWriter instance to write to the file
            //Using cleans up the resource so its not left in memory
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                //write a line to the file
                writer.WriteLine(data1);
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text file.");
                writer.WriteLine("StreamWriter makes it easy to write text to files.");
            }
            //make a message show in the listbox
            lbxLoop.Items.Add("Text written to file successfully.");
        }

        private void btnAppendtext_Click(object sender, EventArgs e)
        {
            StreamWriter appendText;
            appendText = File.AppendText("file.txt");
            //write a line to the file
            appendText.WriteLine("Lets add this text");
            appendText.WriteLine("New high Score = 500");
            appendText.Close();

            //make a message show in the listbox
            lbxLoop.Items.Add("Text appended to file successfully.");
        }
    }
}
