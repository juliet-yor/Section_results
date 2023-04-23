## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*Примеры:*
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм выполнения:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма 
3. Снабдить репозиторий оформленным текстовым описанием решения 
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом 

### Блок-схема 
Ссылка на [блок-схему](https://github.com/juliet-yor/Section_results/blob/main/Algoritm.png)

### Описание решения
С консоли указываем длину вводимого массива, и присваеваем это значение массиву. Пишем условие для отбора в новый массив (длина строки <= 3). Создаем отдельный счетчик для нового массива. В цикле заполняем первичный массив данными, и проверяем каждый введеный элемент на условие отбора в новый массив (длина строки <= 3), если условие правдиво, то сохраняем элемент в новый массив и возвращаем значение. Как только весь исходный массив заполнится и проверится программа выдаст новый массив.

### Программа
Ссылка на [программу](https://github.com/juliet-yor/Section_results/blob/main/Program.cs)