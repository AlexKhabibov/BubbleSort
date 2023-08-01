int n = 5;
int max = 100;

int[] array = new int[n];

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
Console.WriteLine($"[{String.Join(',', array)}]");

for (int j = 0; j < n -1; j++)
    for (int i = 0; i < n - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
            int temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
            }
        }

Console.WriteLine($"[{String.Join(',', array)}]");