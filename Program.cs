// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message) 
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
void ShowArray(string[] array)                                                      // определяем функцию ввода массива
{
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
string[] CreateArray() 
{   
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[10];
    // System.Console.WriteLine($"Введите 'exit' для завершения ввода:");
    for (count = 0; value != "exit"; count++)                                      // непосредственный ввод массива с клавиатуры
    {
        value = Prompt($"Введите {count+1}-е значение или введите 'exit' для завершения ввода ");
        if (value != "exit") {
            secondArray[count] = value;
        }
    }
    string[] array = new string[count-1];
    for (int i = 0; i < array.Length; i++) {
         array[i] = secondArray[i];
    }
    return array;
}
string[] CheckArray(string[] array) 
{   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++) 
    {                                                                             // Перебор массива по элементам
        if (array[i].Length < 4) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++) 
   
 {                                                                                // Проверяем длину введенной строки
        if (array[j].Length < 4) {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}
string[] array = CreateArray();
System.Console.Write("Полученные данные: ");                                      // Вывод полученных данных и результата
ShowArray(array);
System.Console.Write("Результат: ");
ShowArray(CheckArray(array));
