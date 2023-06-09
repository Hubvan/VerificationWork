### Документация к Итоговой проверочной работе

## Условия задачи:
<https://gbcdn.mrgcdn.ru/uploads/asset/4283449/attachment/1251e74b703108ee483caaa98787097d.png>

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []


## Аннотация

1. Запрашиваем ввод колличества элементов массива.
2. Присваиваем введенное колличество элементов переменной *size*.
3. Запрашиваем ввод всех элемментов массива с помощью цикла *for (int i = 0; i < size; i++)* и заполняем с помощью консоли ввода массив *array*;
4. Выполнив цикл *for (int i = 0; i < size; i++)*, в теле которого, расположен оператор if, проверяющий количество символов в текущем элементе массива (их должно быть три или менее)считает количество подходящих условию элементов.
5. с помощью цикла *for (int i = 0; i < array.Length; i++)* перебераем элементы массива *array* и если условие верное *array[i].Length <= symbolSize* ,тогда записываем в новый массив *arrayNew*.
6. Выводим сформированный массив из строк с длиной не более 3 символа.

## Блок-схема программы
<https://drive.google.com/file/d/1kLtWnxOtaIowY0eQfOKcxE6g_JIv_HjD/view?usp=sharing>
![Блок-схема](Diagram.jpg)


## Исходный код
<https://github.com/Hubvan/VerificationWork>
```
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
Console.WriteLine("Полученный массив из строк с длиной не более 3 символа: ");

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

```
## Инструкция пользователя

1. Введите количество элементов массива (только числовое значение);
2. Введите последовательно все элементы массив;
3. Просмотрите введенный массив
4. Просмотрите сформированный массив
5. Повторите проделанное.