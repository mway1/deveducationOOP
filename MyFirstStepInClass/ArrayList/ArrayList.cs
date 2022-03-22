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
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat delete elements");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            Length--;
        }
        public void DeleteFromBeginning()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat delete elements");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            MoveListLeft();
            Length--;
        }

        public void DeleteByIndex(int index)
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat delete elements");
            }

            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            MoveListLeft(index);
            Length--;
        }

        public void DeleteFromEndElements(int count)
        {
            if (Length < count)
            {
                throw new Exception("Length of array < count of elements, what you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }

            for (int i = 0; i < count; i++)
            {
                Length--;
            }
        } 
        public void DeleteFromBeginingElements(int count)
        {
            if (Length < count)
            {
                throw new Exception("Length of array < count of elements, what you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            for (int i = 0; i < count; i++)
            {
                MoveListLeft();
                Length--;
            }
        }
        public void DeleteByIndexElements(int index,int count)
        {
            if (Length < count)
            {
                throw new Exception("Length of array < count of elements, what you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthArray();
            }
            for (int i = 0; i < count; i++)
            {
                MoveListLeft(index);
                Length--;
            }
        }

        public int GetLength()
        {
            return Length;
        }

        public int GetValueByIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new Exception("Index must be>=0 and < Length");
            }
            return _array[index];
        }

        public int FindFirstIndexByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of arr = 0, not found first index");
            }
            int FirstIndex = 0;
            for (int i = 0; i<Length; i++)
            {
                if (_array[i] == value)
                {
                    FirstIndex = i;
                    break;
                }
                else
                {
                    FirstIndex = -1;
                }

            }
            return FirstIndex;
        }

        public void ChangeValueByIndex(int index,int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of arr = 0, not found elements to change");
            }
            if (index > Length)
            {
                throw new Exception("Length must be higher than index");
            }
            _array[index] = value;
        }

        public void ReverseArray()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat");
            }

            int[] newArr = new int[Length];

            for (int i=0; i<Length; i++)
            {
                newArr[i] += _array[Length - 1 - i];
            }
            _array = newArr;

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

        private void MoveListLeft(int index = 0)
        {
            int[] newArray = new int[Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
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
