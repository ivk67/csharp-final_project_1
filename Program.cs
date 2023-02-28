// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message) 
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
void ShowArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
