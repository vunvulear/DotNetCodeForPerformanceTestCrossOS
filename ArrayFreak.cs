namespace TheFightForSurvivingInTheIoTWorld
{
    public class ArrayFreak
    {
        const int orderCycle = 1;
        int[] array = null;

        public ArrayFreak(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        public void Process()
        {
            for (int i = 0; i < orderCycle; i++)
            {
                OrderDesc();
                OrderAsc();
            }

        }

        private void OrderDesc()
        {
            int lenght = array.Length;
            for (int i = 0; i < lenght - 1; i++)
            {
                for (int j = i + 1; j < lenght; j++)
                {
                    if (array[i] < array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }

        private void OrderAsc()
        {
            int lenght = array.Length;
            for (int i = 0; i < lenght - 1; i++)
            {
                for (int j = i + 1; j < lenght; j++)
                {
                    if (array[i] > array[j])
                    {
                        Rotate(i, j);
                    }
                }
            }
        }

        private void Rotate(int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
    }
}