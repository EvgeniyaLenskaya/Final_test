## Задача: 

### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

### Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. ###
 
*При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Описание решения:

### Создаём два массива из строк. В изначальном массиве задаём его размер и содержимое. Второй массив изначально будет равен длине первого. 
### Далее создаём метод, который заполнит второй массив, согласно условию. Чтобы выполнить условие задачи, пройдёмся циклом по первому массиву и внутри цикла зададим условие, по которому каждая строка первого массива должна быть меньше или равна 3 символам. Если условие выполняется, то проверенную строку записываем во второй массив. Чтобы конечный массив не заполнялся пустыми строками, вводим переменную secondArrayIndex, которую после каждой проверки увеличиваем на 1. Действие выполняется, пока не дойдём до конца массива.
### Далее создаём метод, чтобы вывести массивы на экран.