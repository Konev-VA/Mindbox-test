# Mindbox-test

## Тестовое задание для Mindbox

## Задание 1:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным
  

### Ответ:

Легкость добавления новых фигур обусловлена тем, что каждый класс, представляющий собой фигуру, обладает всем функционалом для работы с самим собой (является чем-то вроде Rich Model).

Для добавления новой фигуры следует лишь добавить новый класс и покрыть тестами при необходимости.

Абстракции в виде интерфейса или базового класса не были введены по причине того, что единственное, что объединяет треугольник и круг, это то, что они являются геометрическими фигурами, а также имеют функционал расчёта площади (и тот осуществляется по разным алгоритмам)

В ходе решения были выявлены спорные моменты, которые было бы проще решить, зная контекст использования библиотеки (помечены в комментариях).

---

## Задание 2:

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Ответ:

Связь многие-ко-многим реализована при помощи промежуточной таблицы. Для вывода продуктов без категории использовать LEFT JOIN.

Скрипты прикреплены к репозиторию
