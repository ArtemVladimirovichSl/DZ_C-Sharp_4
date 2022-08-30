int[] array = new int[8];
Random myRandom = new Random();
 
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 9);
    Console.Write(array[i]+" ");
}