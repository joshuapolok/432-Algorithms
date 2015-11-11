using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PA_1_Executable
{
    public partial class Form1 : Form
    {

        private static System.Timers.Timer aTimer;
        int time = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Split the inputed items and display them in the listbox area
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
            var text = inputStream.Text;
            var list = new List<string>();

            list = text.Split(',').ToList() ;

           var parsedList = list.Select(int.Parse).ToList();

            //print items to merge
            foreach(var item in list)
            {
                mergeBox.Items.Add(item);
                quickBox.Items.Add(item);
            }

          

            QuickSort(parsedList, 0, parsedList.Count - 1);

           

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
        public void MergeSort()
        {
           
        }

        public  void QuickSort(List<int> elements,int left, int right)
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
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    
                    quickBox.Items.RemoveAt(i);
                    quickBox.Items.Insert(i, elements[j]);
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

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

    }
}
