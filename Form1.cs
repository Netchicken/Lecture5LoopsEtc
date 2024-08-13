using System.Diagnostics.Metrics;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lecture5LoopsEtc
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {

            const string someText = "you can never change this text";
            // someText = "I'll try anyway";

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

        private void btnReadTextFromFile_Click(object sender, EventArgs e)
        {
            string filePath = "file.txt";

            // Create a StreamReader instance to read from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                //make a variable to hold each line of text
                string line;

                //loop to read each line until there are no more lines (null)
                while ((line = reader.ReadLine()) != null)
                {
                    //add it to the listbox line by line.
                    lbxLoop.Items.Add(line);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //you can specify your initial directory, - this is to my debug folder.
                InitialDirectory = @"C:\\Users\\intel\\source\\repos\\Lecture5LoopsEtc\\bin\\Debug\\net8.0-windows\\",
                //lets filter to only see text files.
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };


            //if you click OK in the dialog box
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string filePath = openFileDialog.FileName;

                // Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {

                    //make a variable to hold each line of text
                    string line;

                    // loop to read each line until there are no more lines(null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //add it to the listbox line by line.
                        lbxLoop.Items.Add(line);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                //you can specify your initial directory, - this is to my debug folder.
                InitialDirectory = @"C:\\Users\\intel\\source\\repos\\Lecture5LoopsEtc\\bin\\Debug\\net8.0-windows\\",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Title = "Save a Text File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the file to save
                string filePath = saveFileDialog.FileName;

                // Write some text to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, World!");
                    writer.WriteLine("This is a sample text file.");
                    writer.WriteLine("SaveFileDialog makes it easy to save files.");
                }
            }
        }
    }
}
