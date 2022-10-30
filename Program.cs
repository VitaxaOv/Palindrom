// See https://aka.ms/new-console-template for more information

int number = 12321;

int count = GetLength(number);

int GetLength(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /=10;
        count++;
    }

    return count;
}

int[] ToArray(int number)
{
    int length = GetLength(number);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
       int lastNumber = number % 10;
        array[i] = lastNumber;
        number /=10;
    }

    return array;
}

bool CheckOnPalindrome(int number)
{
    int[] array = ToArray(number);
    for (var i = 0; i < array.Length; i++)
    {
        array[i] // с начала в конец
        array[array.Length - 1 - i]; // с конца в начало.
        // нужно проверить что это палиндром.
    }
}

