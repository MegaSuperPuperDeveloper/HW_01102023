// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Функция для пополнения массива трехзначными числами
int[] PullArray(int[] array) {
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

// Функция для вывода массива
void PrintArray(int[] array) {
    int length = array.Length;
    Console.Write("[");
    for(int i = 0; i < length; i++) {
        if(i + 1 == length ) {
            Console.Write($"{array[i]}]");
        } else {
            Console.Write($"{array[i]}, ");
        }
    }
}

// Функция для вывода количества четных чисел в массиве
int CountOfNumbers(int[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i] % 2 == 0) {
            count++;
        } 
    }
    return count;
}

var length = new Random().Next(1, 10);
int[] array = new int[length];
PullArray(array);
PrintArray(array);
Console.Write($" -> {CountOfNumbers(array)}");