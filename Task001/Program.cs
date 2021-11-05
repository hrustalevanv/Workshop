//Сформировать случайным образом N-элементный массив, 
//заполненный однозначными целыми числами разных знаков. 
//Задать k и выяснить:
//сколько раз повторяется k в массиве
//сколько элементов находится между первым и последним k
//сколько раз встречается k

//Создаем массив
int povt = 0;   //Cколько раз повторяется k
int naxod = 0; //сколько элементов находится между первым и последним k
int k = 2; //задали переменную
int j1 = 0; //первый к
int jn = 0; //последний к
int index = 0; 
 
                    //0 1 2 3 4 5 6 7 8  9
int[] N = new int[] {1,2,3,2,5,6,2,8,9,-1};
//Создание объекта для генерации чисел
Random rnd1 = new Random();

while(index <= 9 )
{
  //Получить случайное число (в диапазоне от 0 до 10)    
  N [index] = rnd1.Next(-9, 9);
   // Console.WriteLine($"Елемент массива {index} = {N[index]} ");
 index ++;
}

for(index = 0; index <= 9; index++)
{
Console.WriteLine($"Елемент массива {index} = {N[index]} ");

}

for(index = 0; index <= 9; index++)
{
  if (N[index] == k)
  {
    povt++;
    j1 = index;
    index=10;
  }
}

for(index = j1+1; index <= 9; index++)
{
  if (N[index] == k)
  {
    povt++;
    jn = index;
  }
}

naxod = jn - j1 - 1;
Console.WriteLine($"К повторяется в массиве {povt} раз ");

  if (j1 > 0)
  {
    if (jn > 0)
    {
      Console.WriteLine($"Между первым и последним К {naxod} элементов ");
    }
    else
    {
      Console.WriteLine($"К встречается в массиве 1 раз");
    }
  }
  else
  {
    Console.WriteLine($"К встречается в массиве 0 раз");
  }

Console.WriteLine($"j1 {j1}");
Console.WriteLine($"jn {jn}");
