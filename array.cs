using System;
public class Array
{
    private int[] numbers;
    private int count;
    public Array ( int size)
    {
        numbers = new int [size];
        count = 0;
    }
    public void Add (int number) // Thêm phần tử có Big O là n
    {
        if ( count < numbers.Length)
        {
            numbers[count] = number;
            count++;
        }
    }
    public void Remove(int number)
    {
        int count = 0;
        foreach( var item in numbers)
        {
            if( item == number )
            {
                count++;
            }
            if (count==0) { return;}
        }
        int[] newArray = new int[numbers.Length - count];
        int index = 0;

        // Sao chép các phần tử 
        foreach (var item in numbers)
        {
            if (item != number)
            {
                newArray[index++] = item;
            }
        }

        
        numbers = newArray;
    }
}