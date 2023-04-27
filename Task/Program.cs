// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int size = SetNumber("строк");
string [] array = GetArray(size);
PrintMatrix(array);
string[] matrix = Perebor(array, size);
PrintMatrix(matrix);

int SetNumber(string text)
{
    Console.Write($"Введите количество {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] Perebor(string[] array, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] matrix = new string[count];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            matrix[j] = array[i];
            j++;
        }
    }
    return matrix;
}

void PrintMatrix(string[] array)
{
    string text = "[" + string.Join(", ", array) + "]";
    Console.WriteLine(text);
}