# <span style="color:yellow"> Итоговая проверочная работа </span>

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритмa (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)


## <span style="color:yellow"> Задача


Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

<span style="color:lightyellow">**Пример: [ "hello" , "2" , "world" , ":-)" ] -> [ "2" , ":-)" ]**

## <span style="color:yellow">Описание решения</span>
1. Создаем массив строк вручную:
задаём размер будущего массива, объявляем массив sourceArray.
В цикле for (i = 0, N, 1) наполняем массив значениями, которые вводим построчно с клавиатуры.

2. Для вывода элементов одномерного массива создаем метод PrintArray.

3. Объявляем массив resultArray, такой же длины как и sourceArray.
Объявляем переменную count - счетчик для определения длины результирующего массива.

4. Выполняем цикл for (i = 0, N, 1). Внутри цикла идет проверка условия (<=3), если длина элемента массива удовлетворяет условию, то элемент начального массива заносится в count элемент результирующего массива. После этого увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется пока не проверим все элементы начального массива счетчиком i.

5. Mетодом PrintArray выводим массив resultArray на экран.