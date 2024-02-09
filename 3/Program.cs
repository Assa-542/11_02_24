int[] arr = {1, 2, 5, 0, 10, 34}; 
        void ShowReversedArray (int[] array, int i = 0)
        {
            if (i != array.Length)
            {
            ShowReversedArray(array, i+1);
            Console.Write(array[i] + " ");
            }
        }
        ShowReversedArray (arr);