using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SearchandSort
{
    public partial class Form1 : Form
    {

        //making any variables that may be neeeded
        public int[] PresortedArray = new int[10];
        int ArrayLimit = 100;
        int[] TestArray = new int[5] { 8, 3, 55, 7, 9 };



        public Form1()
        {
            InitializeComponent();
        }

        //All of the button clicks
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int searchinput = Convert.ToInt32(txtSearchInput.Text);
                searchinput = BianarySearch(PresortedArray, searchinput);
                lblSearchPosition.Text = Convert.ToString(searchinput);
            }
            catch
            {
                MessageBox.Show("You fool. You absolute buffoon. You really thought that you would break my code by entering something wrong? Or perhaps even nothing at all? Did you think to yourself, 'Oh look at me, im going to click all of the little buttons willy nilly like a little hampster trotting along the top of the keyboard'? Or maybe it was 'Well I know spencer wouldn't put in a simple try catch to fix an error like this, so why not break his code and make him look like a goon'. But no. It is you who is the goon. The next time you stumble across the mirror, I want you to take a nice hard look at yourself and reevaluate your life choices. Every possible decision that led up to that point. And I want you to think about what you could've done instead to make sure you didn't wind up reading this long paragraph and making yourself look like a pile of cinder blocks. Good day.");
            }
           
            

        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            lblSteps.Text = "";
            //DisplayPreValues(RandomizeArray(TestArray));
            DisplayPreValues(RandomizeArray(PresortedArray));
            DisplayPostValues(SelectionSort(PresortedArray));
        }

        private void btnInsertSort_Click(object sender, EventArgs e)
        {
            lblSteps.Text = "";
            DisplayPreValues(RandomizeArray(PresortedArray));
            DisplayPostValues(ImprovedInsertionSort(PresortedArray));
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            lblSteps.Text = "";
            DisplayPreValues(RandomizeArray(PresortedArray));
            DisplayPostValues(mergeSort(PresortedArray));
        }



        //takes in an empty array and gives it random values and returns it
        public int[] RandomizeArray(int[] array)
        {
            Random rdm = new Random();
            for (int ii = 0; ii < array.Length; ii++)
            {
                array[ii] = rdm.Next(0, ArrayLimit);
            }

            return array;
        }

        //puts the values of the PRESORTED array into the corrosponding label
        public void DisplayPreValues(int[] presort)
        {
            string prereturn = "";

            for (int ii = 0; ii < presort.Length; ii++)
            {
                prereturn += presort[ii];
                prereturn += " ";
            }

            lblPresortedNumbers.Text = prereturn;
        }

        //puts the values of the SORTED array into the corrosponding label
        public void DisplayPostValues(int[] postsort)
        {
            string postreturn = "";

            for (int ii = 0; ii < postsort.Length; ii++)
            {
                postreturn += postsort[ii];
                postreturn += " ";
            }

            lblSortedNumbers.Text = postreturn;
        }


        //This is selectionsort
        //This is selectionsort
        //This is selectionsort
        public int[] SelectionSort(int[] array)
        {

            int lowestnumber = ArrayLimit + 1;
            int positiontracker = 0;
            //int counter = 0;

            for (int jj = 0; jj < array.Length; jj++)
            {

                for (int ii = 0; ii < array.Length - jj; ii++)
                {
                    if (array[ii + jj] < lowestnumber)
                    {
                        lowestnumber = array[ii + jj];
                        positiontracker = ii + jj;
                    }
                }

                array[positiontracker] = array[jj];
                array[jj] = lowestnumber;
                lowestnumber = ArrayLimit + 1;
                StepVisualiser(array);
            }
            return array;
        }


        //This is insertionsort
        //This is insertionsort
        //This is insertionsort
        public int[] InsertionSort(int[] array)
        {
            int temp;
            int tempspot;
            int aftertempspot;
            bool isfinished = false;

            //this swaps the first two numbers in the array if need be
            if (array[0] > array[1])
            {
                temp = array[0];
                array[0] = array[1];
                array[1] = temp;
            }

            //because the first two numbers are sorted, there only needs to be an amount of iterations 
            //equal to the number of terms in the array that havent been sorted (array.length - 2)
            for (int ii = 1; ii < array.Length - 2; ii++)
            {
                //makes sure that the comparisons will continue to happen an adiquite number of times
                while (isfinished == false) 
                {
                    //this part is fucking me up hang on
                    for (int jj = ii + 2; jj < ii + 2; jj--)
                    {
                        //checks to see if the number that we're on is smaller than the number being cycled through
                        //if it is, then it does this nice little code in here
                        if (array[jj] > array[ii + 2])
                        {
                            //we need this 'if' in here to make sure that if the number being compared
                            //is the smallest number, it will get put in correctly
                            if(array[ii] > 8) // bs
                            {

                            }
                            else //if it isn't the smallest number it'll run this
                            {
                                tempspot = jj; //stores the array position of the number triggering the 'if'
                                temp = array[jj + 1]; //stores the value of said number ^^^
                                aftertempspot = jj + 1; //array position of number after [wont need later]                
                                
                                array[jj + 1] = array[ii + 2]; //sets the number being compared to the right place

                                for (int yy = 0; yy < array.Length - ii; yy++) //this part is supposed to cycle through the 
                                    //array and make all of the numbers scoot over. Still trying to figure out how long it should be
                                {
                                    array[array.Length - yy] = array[array.Length - (yy - 1)]; 
                                }
                                array[jj + 2] = temp;
                                isfinished = true; //
                            }                                                                                       
                        }

                    }
                    isfinished = true;
                } 
                isfinished = false;

            }

            return array;
        }

        //This is the insertionsort that actually works. 
        public int[] ImprovedInsertionSort(int[] array)
        {
            int n = array.Length;
            for(int ii = 1; ii < n; ii++)
            {
                int key = array[ii];
                int jj = ii - 1;

                while(jj >= 0 && array[jj] > key)
                {
                    array[jj + 1] = array[jj];
                    jj = jj - 1;
                }
                array[jj + 1] = key;
                StepVisualiser(array);
            }
            return array;

        }


        
        public int[] mergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            int midPoint = array.Length / 2;

            
            left = new int[midPoint];

            
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            
            else
                right = new int[midPoint + 1];
           
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            
            int x = 0;
            
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = mergeSort(left);
            
            right = mergeSort(right);
            
            result = merge(left, right);
            return result;


        }

        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                   
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
               
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;

        }

        public int BianarySearch(int[] array, int value)
        {

            int low = 0;
            int high = array.Length - 1;
            int mid = (low + high + 1) / 2;
            int index = -1;

            do
            {
                if(value == array[mid])
                {
                    index = mid;
                }
                else if(value < array[mid])
                {
                    high = mid - 1;
                }
                else if(value > array[mid])
                {
                    low = mid + 1;
                }

                mid = (low + high + 1) / 2;

            } while ((low <= high) && (index == -1));

            return index;

        }

        public void StepVisualiser(int[] array)
        {
            string arrayoutput = "";
            for(int ii = 0; ii < array.Length; ii++)
            {
                arrayoutput += array[ii];
                arrayoutput += " ";
            }
            lblSteps.Text += arrayoutput;

            lblSteps.Text += "\n";
        }
    }
}
