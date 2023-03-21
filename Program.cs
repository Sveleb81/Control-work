Console.Write("Введите число элементов массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
string [] arr = new string[arrLength];
string [] resultArr = new string[arrLength];

Console.WriteLine("Заполните массив: ");
for (int i = 0; i < arrLength; i++) {
    Console.Write($"{i + 1}: ");
    arr[i] = Console.ReadLine() ?? "";
}

int resultArrLength = 0;

for (int i = 0; i < arrLength; i++) {
    if (arr[i].Length < 4) {
        resultArr[resultArrLength++] = arr[i];
    };
}

Array.Resize(ref resultArr, resultArrLength);

string strResultArr = "[";

for (int i = 0; i < resultArrLength; i++) {
    strResultArr += $"'{resultArr[i]}'";
    if (i != resultArrLength - 1) strResultArr += ", ";
}

strResultArr += "]";

Console.Write($"Получившийся массив: {strResultArr}");

