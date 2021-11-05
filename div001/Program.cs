// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 

// Задать массив
int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 99); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index < 10)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
Console.WriteLine(currentElement);
while (index < 10)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}

//Больше среднего арифметического элементов A
int sum1 = array[0];
for(index = 1; index < 10; index ++)
{
   sum1 = sum1 + array[index];
}

double average = sum1 / 10;
// печатаем массив больше среднего арифметического
Console.WriteLine($"Массив больше среднего арифметического");
index = 0;

while (index < 10)
{
    if (array[index] > average)
    {
     Console.WriteLine($"Элемент больше среднего арифметического {array[index]} ");   
    }
    
    index++;
}

//Console.WriteLine();

//чётные
index = 0;
while(index < 10) 
{
  if(array[index] % 2 == 0)
  {
    Console.WriteLine("Четное");
  }
    else
    {
      Console.WriteLine("Нечетное");
    }
    index ++;
}
