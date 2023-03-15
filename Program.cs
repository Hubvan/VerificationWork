Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
  Console.Write("Введите элемент массива: ");
  string result = Console.ReadLine();
  array[i] = result;
}
Console.WriteLine(string.Join(",", array));

int count = 0;
int symbolSize = 3;

for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= symbolSize)
  {
    count++;
  }
}
Console.WriteLine("Сформированный массив из строк с длиной не более 3 символа: ");

string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= symbolSize)
  {
    newArray[j] = array[i];
    Console.Write(newArray[j] + ",");
    j++;
  }
}