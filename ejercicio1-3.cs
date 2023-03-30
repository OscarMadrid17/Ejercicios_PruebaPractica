//Ejercicio 1.3

using System;
 
public class ArreglarMatriz_Asc
{
    public static void Main()
    {
        int[] array = new int[] { 17,9,36,8,7,3,15,28,57};
 
        Array.Sort(array, (x, y) => y.CompareTo(x));
 
        Console.WriteLine(String.Join(", ", array));       
    }
}