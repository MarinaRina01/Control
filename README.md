#Итоговая контрольная работа по основному блоку
---
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
1. Создать репозиторий на **GitHub**;
2. Нарисовать **блок-схему алгоритма** (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод);
3. Снабдить репозиторий оформленным **текстовым** описанием решения;
4. Написать **программу**, решающую поставленную задачу;
5. Использовать **контроль версий** в работе над этим небольшим проектом;

##Задача 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

---
##Описание решения

Вначале создаем стандартные методы *SetNumber* и *GetArray*, первый из которых позволяет вывести в терминал сообщение и последующим чтением того, что ввел пользователь с конвертацией. Второй метод позволяет задать массив, в котором введеные пользователем слова или числа будут элементами массива.
Метод *PrintMatrix* выводит на экран заданный массив.
Метод *Perebor* позволяет пройтись по элементам массива, выявить элементы где в строке меньше, либо равно 3 символа, и создать новый массив с этим условием. Этот метод возвращает новый массив, который в последствии выводится на экран.