// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Функция для пополнения массива трехзначными числами
int[] PullArray(int[] array) {
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(1, 100);
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

int SummaOfNumbers(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if(i % 2 != 0) {
            sum += array[i];
        }
    } 
    
    return sum;
}

var length = new Random().Next(3, 10);
int[] array = new int[length];
PullArray(array);
PrintArray(array);
Console.Write(" -> ");
Console.WriteLine(SummaOfNumbers(array));
