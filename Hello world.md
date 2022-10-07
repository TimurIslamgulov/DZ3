# *Инструкция*
***Контроль версий***

# Основновный команды Git

**git innit** - инициализация программного репозитория 

**git status** - получить информацию от git о его текущем состоянии

**git add** - добавить файл или файлы к следующему коммиту

**git commit-m "message"** - создание коммита

**git log** - вывод на экран истории всех коммитов с их хеш-кодами

**git checkout** - переход от одного коммита к другому

**git checkout master** - вернуться к актуальному сотсоянию и продолжит работу

**git diff** - увидеть разницу между текущим файлом и закоммиченным файлом 

> Это блок цитирования. Обычно он отображается с отступом и имеет другой цвет фона.

> [!WARNING]
> Dangerous certain consequences of an action.

```java
:::row:::
   :::column span="":::
      Content...
   :::column-end:::
   :::column span="":::
      More content...
   :::column-end:::
:::row-end:::
```
# Это первый уровень заголовка

## Это второй уровень заголовка

###### Это шестой уровень заголовка

**Нумерованный список**
1. This is
1. a parent numbered list
   1. and this is
   1. a nested numbered list
1. (fin)

**Маркированный список**
- This is
- a parent bulleted list
  - and this is
  - a nested bulleted list
- All done!

**Контрольный список**
> * List item 1
> * List item 2
> * List item 3


**Таблицы**
|This is   |a simple   |table header|
|----------|-----------|------------|
|table     |data       |here        |
|it doesn't|actually   |have to line up nicely!|

**Подстрочные и надстрочные символы**

Hello <sub>This is subscript!</sub>

Goodbye <sup>This is superscript!</sup>



> [Справочник](https://learn.microsoft.com/ru-ru/contribute/markdown-reference)

## Добавить изображение ##

![GIT](LOGO.jpg)

# **Работа с удаленными репозиториями**

***Работа с удаленными репозиториями в GitHub***

**Основные команды**

- git clone - склонировать внешний репозиторий на ПК
- git pull - скачать все из текущего репозитория и автоматически
сделать merge с нашей версией 
- git push - отправить нашу версию репозитория на внешний
репозиторий. ТРЕБУЕТ АВТОРИЗАЦИИ на внешнем репозитории

# Как сделать pull request

- Делаем fork репозитория
- Делаем clone СВОЕЙ версии репозитория
- Создаем новую ветку и в НЕЕ вносим свои изменения
- Фиксируем изменения (делаем коммиты)
- Отправляем свою версию в свой GitHub
- На сайте GitHub нажимаем кнопку pull request 