using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task9
    {
        private int[,] array;

        public task9(params int[][] values)
        {
            array = new int[values.GetLength(0), values[0].GetLength(0)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values[0].GetLength(0); j++)
                {
                    array[i, j] = values[i][j];
                }
            }
        }


        public int this[int first_index,int second_index]
        {
            get
            {
                try
                {
                    return array[first_index, second_index];

                } catch
                {
                    return -1;
                }
            }
            set
            {
                try
                {
                    array[first_index, second_index] = value;

                }
                catch
                {
                    Console.WriteLine("ASHIPKA");
                }
            }
        }

        public int this[int index]
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[index, i] > max) max = array[index, i];
                }
                return max;
            }
            set
            {
                int max = int.MinValue, index_of_max = 0; ;
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[index, i] > max) {
                        max = array[index, i];
                        index_of_max = i;
                    }
                }
                array[index, index_of_max] = value;
            }
        }

    }
}
