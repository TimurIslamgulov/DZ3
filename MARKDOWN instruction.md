# Инструкция для работы с MARKDOWN

В данной статье мы познакомимся с широим спектром функционала языка разметки Markdown.

## Выделение текста

Чтобы выделить текст курсивом, необходимо обрамить его звездочками (*) или знаком нижнего подчеркивания (_).

Например:

*вот так*

_или вот так_

Чтобы выделить текст полужирным, необходимо обрамить его двойными звездочками(**), или двойным знаком нижнего подчеркивания (__).

Например:

**вот так**

__или вот так__

Альтернативные способы выделения текста нужны для того, что бы мы могли совмещать оба этих способа.

Например:

_текст одновременно может бы выделин курсивом и **полужирным**._
## Списки

Чтобы выделить ненумерованный список используйте (*) или (+)

например:

* элемент 1
* элемент 2
* элемент 3
+ элемент 4

Что бы добавить нумерованный список, пункты необхъодимо просто пронумеровать.

Напрмер:

1. Пункт первый
2. Пункт второй
3. Пункт третий

## Работа с изображеними

Чтобы вставить изображение в текст, достаточно написать:

![привет.это котик](kotik.jpg)
## Ссылки

Это встроенная [ссылка с title элементом](http://example.com/link "Я ссылка"). Это — [без title](http://example.com/link).

А вот [пример][1] [нескольких][2] [ссылок][id] с разметкой как у сносок. Прокатит и [короткая запись][] без указания id.

[1]: http://example.com/ "Optional Title Here"
[2]: http://example.com/some
[id]: http://example.com/links (Optional Title Here)
[короткая запись]: http://example.com/short

Вынос длинных урлов из предложения способствует сохранению читабельности исходника. Сноски можно располагать в любом месте документа.
## Работа с таблицами

| col 3 is      | some wordy text |     **$1600** |
| col 2 is      | centered        |         $12   |
| zebra stripes | are neat        |        ~~$1~~ |

Внутри таблиц можно использовать ссылки, наклонный, жирный или зачеркнутый текст.

Для всего остального есть обычный HTML.В чистом Маркдауне нет синтаксиса для таблиц, а в GFM есть.

First Header  | Second Header
------------- | -------------
Content Cell  | Content Cell
Content Cell  | Content Cell

Для красоты можно и по бокам линии нарисовать:

| First Header  | Second Header |
| ------------- | ------------- |
| Content Cell  | Content Cell  |
| Content Cell  | Content Cell  |

Можно управлять выравниванием столбцов при помощи двоеточия.

| Left-Aligned  | Center Aligned  | Right Aligned |
|:------------- |:---------------:| -------------:|

## Цитаты

Цитаты оформляются как в емейлах, с помощью символа `>`.

> This is a blockquote with two paragraphs. Lorem ipsum dolor sit amet,
> consectetuer adipiscing elit. Aliquam hendrerit mi posuere lectus.
> Vestibulum enim wisi, viverra nec, fringilla in, laoreet vitae, risus.
>
> Donec sit amet nisl. Aliquam semper ipsum sit amet velit. Suspendisse
> id sem consectetuer libero luctus adipiscing.

Или более ленивым способом, когда знак `>` ставится перед каждым элементом цитаты, будь то абзац, заголовок или пустая строка:

> This is a blockquote with two paragraphs. Lorem ipsum dolor sit amet,
consectetuer adipiscing elit. Aliquam hendrerit mi posuere lectus.
Vestibulum enim wisi, viverra nec, fringilla in, laoreet vitae, risus.
>
> Donec sit amet nisl. Aliquam semper ipsum sit amet velit. Suspendisse
id sem consectetuer libero luctus adipiscing.

В цитаты можно помещать всё что угодно, в том числе вложенные цитаты:

> ## This is a header.
>
> 1.   This is the first list item.
> 2.   This is the second list item.
>
> > Вложенная цитата.
>
> Here's some example code:
>
>     return shell_exec("echo $input | $markdown_script");

## Загрузка и выгрузка проэкта на Github.

###  Загрузка и выгрузка репозитория со своего аккаунта.

1. Создать аккаунт на Github
2. Создать локальный репозиторий
3. Активировать в аккаунте Github профиль VScode
4. Командой PUSH отправить локальный репозиторий в удаленный на Github (возможна авторизация на удаленном репозитории)
5. Загружаем удаленный репозиторий в локальной командой PULL
### Загрузка  и выгрузка репозитория с другого аккаунта( в т.ч. и закрытого).

1. Создать fork  репозитория в Github
2. Создать git clone для другой версии репозитория
3. Создать отдельную ветку изменений в репозитории
4. Все изменения производятся только в созданной ветки
5. Отправить репозиторий с изменениями на свой аккаунто командой push
6. В Github отправляем pull request.
## Заключение

В дальнейшем список функционала будет пополняться новыми статьями.

Это далеко не полный перечень функционала Markdown. Подробнее можно узнать из интернета.