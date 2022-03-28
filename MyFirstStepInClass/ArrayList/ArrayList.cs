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

        public MyArrayList(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public MyArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
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
            if (index > Length || index < 0)
            {
                throw new ArgumentException("index > length or < 0");
            }

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
            Length--;
        }
        public void DeleteFromBeginning()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat delete elements");
            }
            MoveListLeft();
            Length--;
        }

        public void DeleteByIndex(int index)
        {
            if (index>Length || Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try repeat delete elements");
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
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }

            int[] newArr = new int[Length];

            for (int i=0; i<Length; i++)
            {
                newArr[i] += _array[Length - 1 - i];
            }
            _array = newArr;

        }

        public int FindMaxElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }

            int max = _array[0];

            for (int i=0; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max=_array[i];
                }
            }
            return max;
        }
        public int FindMinElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }

            int min = _array[0];

            for (int i=0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min=_array[i];
                }
            }
            return min;
        } 
        public int FindIndexOfMaxElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }

            int max = _array[0];
            int indexMax = 0;

            for (int i=0; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max=_array[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
        public int FindIndexOfMinElement()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }

            int min = _array[0];
            int indexMin = 0;
            for (int i=0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min=_array[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        public void SortAscendingBubbleSort()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }
            int temp;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        temp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }
        public void SortDescendingSelectSort()
        {
            if (Length < 1)
            {
                throw new Exception("Length of array < 1, add elements and try to repeat");
            }
            for (int i = 0; i < Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] > _array[min])
                    {
                        min = j;
                    }
                }
                int temp = _array[min];
                _array[min] = _array[i];
                _array[i] = temp;
            }
        }

        public int DeleteFirstByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Length of arr = 0, not found elements to delete");
            }

            int firstIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    firstIndex = i;
                    DeleteByIndex(firstIndex);
                    break;
                }
                else
                {
                    firstIndex = -1;
                }
            }
            return firstIndex;

        }

        public int DeleteAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }
        public void AddListToEnd(MyArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            AddList(list);
        }

        public void AddListToBegining(MyArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            AddListWithIndex(list);
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

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }

            return s;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is MyArrayList))
            {
                isEqual = false;
            }
            else
            {
                MyArrayList list = (MyArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
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

        private void AddList(MyArrayList list)
        {
            int[] newArray = new int[list.Length + this.Length];
            for (int i = 0; i < this.Length; i++)
            {
                newArray[i] = this[i];
            }
            for (int i = this.Length; i < newArray.Length; i++)
            {
                newArray[i] = list[i - Length];
            }
            Length += list.Length;
            _array = newArray;
        }
        private void AddListWithIndex(MyArrayList list, int index = 0)
        {
            int[] newArray = new int[list.Length + _array.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < list.Length + index; i++)
            {
                newArray[i] = list[i - index];
            }
            for (int i = index + list.Length; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - list.Length];
            }
            Length += list.Length;
            _array = newArray;
        }


    }
}
