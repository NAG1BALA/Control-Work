// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] StartArray = { "Kaliningrad", "hi", "1234", "Moscow", "Ufa", "138", "Sochi", "rs5" };
int count = 0;

for (int i = 0; i < StartArray.Length; i++)
        for (int j = 0; j < StartArray.Length - i - 1; j++)
        {
            if (StartArray[j].Length > StartArray[j + 1].Length)
            {
                string temp = StartArray[j];
                StartArray[j] = StartArray[j + 1];
                StartArray[j + 1] = temp;
            }
        }


for (int i = 0; i < StartArray.Length; i++)
{
    if (StartArray[i].Length <= 3)
    {
        count++;
    }
}

string[] NewArray = new string[count];
for (int i = 0; i < NewArray.Length; i++)
{
    
    {
        NewArray[i] = StartArray[i];
    }
}
Console.WriteLine($"[ {string.Join(", ", NewArray)} ]");