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
        /// <author>Joshua Poling</author>
        /// <date>November 11, 2015</date>
        /// <history>
        /// Date   Author    Change Reason     Change Description
        /// ----------------------------------------------------------------
        /// 
        /// ----------------------------------------------------------------
        /// </history>
        private void SubmitButton(object sender, EventArgs e)
        {
            quickBox.Items.Clear();
            mergeBox.Items.Clear();
            var text = inputStream.Text;
            var list = new List<string>();
            List<int> parsedList;

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
                list = text.Split(' ').ToList();

                try
                {
                     parsedList = list.Select(int.Parse).ToList();

                    //print items to merge
                    foreach (var item in list)
                    {
                        mergeBox.Items.Add(item);
                        quickBox.Items.Add(item);
                    }

                    watch1.Start();
                    QuickSort(parsedList, 0, parsedList.Count - 1);
                    watch1.Stop();

                    span1 = watch1.Elapsed;
                    quickLabel.Text = "Quick Sort Time: " + span1 + " Seconds";

                    watch2.Start();
                    MergeSort(parsedList, 0, parsedList.Count - 1);
                    watch2.Stop();

                    span2 = watch2.Elapsed;
                    mergeLabel.Text = "Merge Sort Time: " + span2 + " Seconds";

                    var outString = String.Format("{0,-20} {1,-30} {2,-20}", "Sort-Type", "Length", "Time") + Environment.NewLine;
                    outString += String.Format("{0,-20} {1,-30} {2,-20}", "Merge Sort", mergeBox.Items.Count, span1 + " Seconds") + Environment.NewLine;
                    outString += String.Format("{0,-20} {1,-30} {2,-20}", "Quick Sort", quickBox.Items.Count, span2 + " Seconds") + Environment.NewLine;

                    WriteFile(outputTxt.Text, outString);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Integers only!");
                }
            }

        }

        /// <summary>
        /// Merge sort the items in the listbox
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
        public void MergeSort(List<int> numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);

                Merge(numbers, left, (mid + 1), right);
            }
        }
    
        /// <summary>
        /// Merge sort the items in the listbox
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
        public void Merge(List<int> numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Count];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                mergeBox.Items.RemoveAt(right);
                mergeBox.Items.Insert(right,numbers[i]);
                right--;
            }
        }
    

        /// <summary>
        /// Merge sort the items in the listbox
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
        public void QuickSort(List<int> elements,int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                
                if (i <= j)
                {
                    // Swap, and swap elements in text box
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    quickBox.Items.RemoveAt(i);
                    quickBox.Items.Insert(i, elements[j]);

                    elements[j] = tmp;
                    quickBox.Items.RemoveAt(j);
                    quickBox.Items.Insert(j, tmp);
                    
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
                var folderName = folderBrowserDialog1.SelectedPath;
                outputTxt.Enabled = false;
                outputTxt.Text = folderName;
            }
        }

        public void WriteFile(string path, string text)
        {
            File.WriteAllText(path + @"\\PA-1-Ouput-Chart.txt", text);
        }
    }
}
