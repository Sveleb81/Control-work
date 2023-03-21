# Control-work

## Задача:
>Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам

## Решение:

1. **Объявляем переменные:**

Пользователь вводит размер `arrLength` исходного массива. Объявляем исходный `arr` и результирующий `resultArr` массив с длинами равные введенному пользователем значению

```java
int arrLength = Convert.ToInt32(Console.ReadLine());
string [] arr = new string[arrLength];
string [] resultArr = new string[arrLength];
```

2. **Заполняем исходный массив:**

Пользователь заполняет массив `arr`

```java
for (int i = 0; i < arrLength; i++) {
    Console.Write($"{i + 1}: ");
    arr[i] = Console.ReadLine() ?? "";
}
```

3. **Заполняем результирующий массив:**

Объявляем переменную `resultArrLength` в которой будем хранить длину массива `resultArr`. Далее проверяем каждый элемент массива `arr`. Если длина элемента оказывается меньше 4, то мы добавляем этот элемент в массив `resultArr` и увеличиваем на единицу `resultArrLength`. В конце мы при помощи метода `Array.Resize` удаляем лишние элементы массива, если они имеются

```java
int resultArrLength = 0;

for (int i = 0; i < arrLength; i++) {
    if (arr[i].Length < 4) {
        resultArr[resultArrLength++] = arr[i];
    };
}

Array.Resize(ref resultArr, resultArrLength);
```

4. **Выводим получившийся массив:**

```java
string strResultArr = "[";

for (int i = 0; i < resultArrLength; i++) {
    strResultArr += $"'{resultArr[i]}'";
    if (i != resultArrLength - 1) strResultArr += ", ";
}

strResultArr += "]";

Console.Write($"Получившийся массив: {strResultArr}");
```