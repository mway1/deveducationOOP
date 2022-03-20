using System;


namespace ArrayList
{
    public class MyArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public MyArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public void AddLast(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }
        public void AddFirst(int value)
        {
            if (Length+1 >= _array.Length)
            {
                UpSize();
            }

            MoveListRight();

            _array[0] = value;
            Length++;
        }

        public void AddByIndex(int index,int value)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            MoveListRight(index);
            _array[index] = value;
            Length++;
        }

        public void DeleteFromEnd()
        {
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            Length--;
        }
        public void DeleteFromBeginning()
        {
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            MoveListLeft();
            Length--;
        }

        public void Write()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
        private void DecreaseLengthArray()
         {
            int newLength = _array.Length / 3;
            int[] newArr = new int[newLength];
            Copy(newArr);
        }

        private void Copy(int[] newArr)
        {
            for (int i = 0; i < _array.Length; i++)
            {
              newArr[i] = _array[i];
            }
            _array = newArr;
        }


        private void MoveListRight(int index=0)
        {
            int[] newArr = new int[Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArr[i + 1] = _array[i];
            }
            _array = newArr;
        }

        private void MoveListLeft()
        {
            int[] newArr = new int[Length - 1];
            for (int i = 0; i < Length - 1; i++)
            {
                newArr[i] = _array[i + 1];
            }
            _array = newArr;
        }


        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

    }
}
