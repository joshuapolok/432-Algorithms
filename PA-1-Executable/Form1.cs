using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace PA_1_Executable
{
    public partial class Form1 : Form
    {
        // timers and stopwatches for sorting times
        public Stopwatch watch1 = new Stopwatch();
        public Stopwatch watch2 = new Stopwatch();
        public TimeSpan span1;
        public TimeSpan span2;

        public static string textFileName = @"PA-1-Ouput-Chart.txt";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Split the inputed items and display them in the listbox area. Start
        /// a timer for each sorting function and end the timer after the list
        /// has been sorted. Once the lists are sorted display the time it 
        /// took for the sort to complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Joshua Poling, Erick Roberson, Thanh Nguyen</author>
        /// <date>November 11, 2015</date>
        /// <history>
        /// Date   Author    Change Reason     Change Description
        /// ----------------------------------------------------------------
        /// 
        /// ----------------------------------------------------------------
        /// </history>
        private void SubmitButton(object sender, EventArgs e)
        {
            //Clear the two listbox for next input
            quickBox.Items.Clear();
            mergeBox.Items.Clear();

            //local variables for storing input string for parsing
            var text = inputStream.Text;
            var list = new List<string>();
            List<int> parsedList;

            //checks to make sure text box are not empty
            if (text == "")
            {
                MessageBox.Show("Must have input");
            }
            else if (!text.Contains(" "))
            {
                MessageBox.Show("Missing space delimiter!");
            }
            else if (outputTxt.Text == "")
            {
                MessageBox.Show("You must select an output destination!");
            }
            
            else
            {
                //split strings into tokens by space delimiters
                list = text.Split(' ').ToList();

                try
                {
                     //converts the list to ints
                     parsedList = list.Select(int.Parse).ToList();

                    //adds the item to the listboxes
                    foreach (var item in list)
                    {
                        mergeBox.Items.Add(item);
                        quickBox.Items.Add(item);
                    }

                    //start timer and call quicksort function
                    watch1.Start();
                    QuickSort(parsedList, 0, parsedList.Count - 1);
                    watch1.Stop();

                    //displays quicksort result
                    span1 = watch1.Elapsed;
                    quickLabel.Text = "Quick Sort Time: " + span1 + " Seconds";

                    //start timer and call mergesort function 
                    watch2.Start();
                    MergeSort(parsedList, 0, parsedList.Count - 1);
                    watch2.Stop();

                    //displays mergesort result
                    span2 = watch2.Elapsed;
                    mergeLabel.Text = "Merge Sort Time: " + span2 + " Seconds";

                    //format strings into readable columns of type, length and time for both sorting algorithmn
                    var outString = String.Format("{0,-20} {1,-30} {2,-20}", "Sort-Type", "Length", "Time") + Environment.NewLine;
                    outString += String.Format("{0,-20} {1,-30} {2,-20}", "Merge Sort", mergeBox.Items.Count, span1 + " Seconds") + Environment.NewLine;
                    outString += String.Format("{0,-20} {1,-30} {2,-20}", "Quick Sort", quickBox.Items.Count, span2 + " Seconds") + Environment.NewLine;

                    //writes results to file
                    WriteFile(outputTxt.Text, outString);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Integers only!");
                }
            }

        }

        /// <summary>
        /// Resursive merge procedure to sort a list
        /// </summary>
        /// <param name="numbers">The list of ints of to be sorted</param>
        /// <param name="left">The begining of the list</param>
        /// /// <param name="right">The end of the list</param>
        /// <author>Joshua Poling, Erick Roberson, Thanh Nguyen</author>
        /// <date>November 11, 2015</date>
        /// <history>
        /// Date   Author    Change Reason     Change Description
        /// ----------------------------------------------------------------
        /// 
        /// ----------------------------------------------------------------
        /// </history>
        public void MergeSort(List<int> numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                //get middle of the list 
                mid = (right + left) / 2;

                //split list and recursively call merge sort function
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);

                //merge the 
                Merge(numbers, left, (mid + 1), right);
            }
        }

        /// <summary>
        /// Function for merging two sorted array
        /// </summary>
        /// <param name="numbers">The list to be merged</param>
        /// <param name="left">The begining of the list</param>
        /// <param name="mid">The middle of the list</param>
        /// <param name="right">The end of the list</param>
        /// <author>Joshua Poling, Erick Roberson, Thanh Nguyen</author>
        /// <date>November 11, 2015</date>
        /// <history>
        /// Date   Author    Change Reason     Change Description
        /// ----------------------------------------------------------------
        /// 
        /// ----------------------------------------------------------------
        /// </history>
        public void Merge(List<int> numbers, int left, int mid, int right)
        {
             //local temporary array for storing the merged array
            int[] temp = new int[right - left + 1];
 
            //local counters
            int i = left, j = mid+1, k=0;

            // Traverse array and store smallest elements of both array
            while (i <= mid && j <= right)
            {
                //check to see if first element of first list is smaller than first element of second list
                if (numbers[i] < numbers[j])
                {
                    //insert smallest element into temp array
                    temp[k] = numbers[i];

                    //increment counters
                    k++;
                    i++;
                }
                else
                {
                    //increment smallest element from second list into temp array
                    temp[k] = numbers[j];

                    //increment counters
                    k++;
                    j++;
                }
            }

            //Add any elements left from first list into temporary array
            while(i<=mid)
            {
                temp[k] = numbers[i];
                k++;
                i++;
            }

            //Add any elements left from the second list into temporary array
            while (j <= right)
            {
                temp[k] = numbers[j];
                k++;
                j++;
            }
 
            //reset counters and clear merge box to output sorted array
            k=0;
            i=left;
            mergeBox.Items.Clear();

            //Replace original list with our temporary array
            while (k < temp.Length && i <= right)
            {
                numbers[i] = temp[k];
                mergeBox.Items.Add(temp[k]);
                i++;
                k++;
            }
        }


        /// <summary>
        /// Sort array using Quick Sort Algorithm
        /// </summary>
        /// <param name="elements">Lists to be sorted</param>
        /// <param name="left">Begining of list</param>
        /// <param name="right">End of list</param>
        /// <author>Joshua Poling, Erick Roberson, Thanh Nguyen</author>
        /// <date>November 11, 2015</date>
        /// <history>
        /// Date   Author    Change Reason     Change Description
        /// ----------------------------------------------------------------
        /// 
        /// ----------------------------------------------------------------
        /// </history>
        public void QuickSort(List<int> elements,int left, int right)
        {
            //local variables to store counters and pivot
            int i = left;
            int j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                //increment i until next element in list is greater than or equal to the pivot element
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                //decrement j until next element in list is less than or equal to the pivot element
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                
                if (i <= j)
                {
                    //Temporary store element i
                    int tmp = elements[i];

                    //swap element i with element j
                    elements[i] = elements[j];

                    //Do same swap in our list box
                    quickBox.Items.RemoveAt(i);
                    quickBox.Items.Insert(i, elements[j]);

                    //insert the temporary i element into element j
                    elements[j] = tmp;

                    //Do same insert in our list box
                    quickBox.Items.RemoveAt(j);
                    quickBox.Items.Insert(j, tmp);
                    
                    //increment and decrement counters
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }
            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }

        private void destBtn_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //get selected path name to store output
                var folderName = folderBrowserDialog1.SelectedPath;

                //ensure textbox is disable so user cannot mess up location
                outputTxt.Enabled = false;

                //prints destination path for user to see
                outputTxt.Text = folderName;
            }
        }

        public void WriteFile(string path, string text)
        {
            //write output to file
            File.WriteAllText(path + @"\\PA-1-Ouput-Chart.txt", text);
        }
    }
}
