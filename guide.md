# <p style="text-align: center;">**Гайд по коммандам git**</p>

<p style="text-align: center;"><img src="https://onlinepngtools.com/images/examples-onlinepngtools/sunset.gif" width="150" height="150"></p>

## **git --version**
Показывает текущую версию git, если он установлен правильно.

<span style="color:#59afe1"> Пример:</span>
>git version 2.38.1.windows.1
***
## **git config user.name/git config user.email**
Чтобы "представиться" системе необходимо использовать данные две команды.
- git config user.name 
<span style="color:#59afe1">"Твое имя в кавычках"</span> - позволит запомнить программе имя пользователя.
- git config user.email
<span style="color:#59afe1">"Твоя электронная почта"</span> - позволит запомнить твой емэйл.
*<p style="text-align: right;">"Заяви о себе, и к тебе заявятся."</p>*
***
## **git init**
Превращает папку в репозиторий, где git начинает отслеживать файлы и их изменения. Для использования необходимо сначала открыть папку в VSC, а затем вбить в терминале команду.

<span style="color:#59afe1">Терминал выведет похожий текст, если не допустить ошибок:</span>
>Initialized empty Git repository in C:/Users/USER/Desktop/123/.git/
***
## **git status**
Показывает, какой  текущий статус у элементов в репозитории.
<span style="color:red">Красным</span> выделяются неотслеживаемые и/или несохраненные файлы. Также команда показывает в какой ветке мы сейчас находимся.

<span style="color:#59afe1">В случае, если все "закоммиченно" и все файлы в репозитории отслеживаются, терминал покажет следующие строчки:</span>
>On branch master   
>nothing to commit, working tree clean

*<p style="text-align: right;">"Пока одни меняют красивые статусы в социальных сетях, другие добиваются реального статуса в жизни..."</p>*
***
## **git add** 
Данная команда добавляет наш файл для создания будущего коммита. Для этого после **git add** необходимо после пробела добавить имя файла или точку. Во втором случае будут добавлены сразу все файлы репозитория.
***
## **git commit** 
Зафиксировать текущее состояние репозитория или конкретного файла может с помощью данной команды.

<span style="color:#59afe1">При вводе следующей команды:</span>
> git commit 
<span style="color:magenta">-m</span> "3d version"

<span style="color:#59afe1">Терминал покажет нечто такое:</span>
> [master 7563727] 3d version   
> 1 file changed, 17 insertions(+), 7 deletions(-)

Выделенная <span style="color:magenta">-m</span> после нашей команды позволяет далее в кавычках написать комментарий, который затем позволит нам понимать, какое было сделано сохранение и для чего.

*<p style="text-align: right;">"Ты просишь меня сделать коммит, но ты просишь это не сделав эдд..."</p>*
***
## **git log/git reflog** 
Данная команда поможет тебе посмотреть существующие коммиты. Первая покажет тебе парочку последних коммитов, а вторая - выведет список всех.

Во время первой ты сможешь с помощью *Enter* или *стрелочки вниз* долистать до необходимого коммита. Когда захочешь выйти, нажми
<span style="color:lime">**Q**</span>.

<span style="color:#59afe1">А вот **git reflog** покажет уже полный список, типа:</span>
><span style="color:yellow">b198e34 (</span>
<span style="color:#59afe1">**HEAD -></span> 
<span style="color:lime"> master**</span>
<span style="color:yellow">)</span> HEAD@{0}: commit: 4th version     
><span style="color:yellow">7563727</span> HEAD@{1}: commit: 3d version   
><span style="color:yellow">2284ee5</span> HEAD@{2}: commit: 2nd version  
><span style="color:yellow">dda5fa3</span> HEAD@{3}: commit (initial): first version

*<p style="text-align: right;">"Цитата сверху заняла восемь строчек кода. Все ради точной цветопередачи...~~Спасите~~"</p>*
***
## **git checkout** 
С помощью этой команды мы можем загрузить раннюю версию, используя те самые странные числа, которые сверху выделены желтым. Достаточно использовать первые 4 от нужнойверсии, указав их после команды.

Вернуться обратно в последнюю версию можно, использовав <span style="color:lime">**git checkout master**</span>.
*<p style="text-align: right;">"Вставить цитату попозже"</p>*
***
## **git diff**
Посмотреть разницу между текущим состоянием и последним коммитом можно введя эту небольшую команду. Так же ее можно использовать и для сравнения других коммитов, для этого через пробелы необходимо ввести две четверки необходимых коммитов. 
<span style="color:#59afe1">Типа так:</span>
> git diff 2284 dda5

***
## **git rm**
Если все достало, то с помощью этой команды можно просто удалить файл. Не забудь указать его имя.


***
***
***

    P.S. Это  [то, что помогало с созданием файла(*наведи курсор, увидишь тайтл*)](https://www.google.ru/webhp?tab=rw&authuser=0 "Я ссылка"). Или — [тут без тайтла](http://example.com/link).

| Команды гит   | Использовались ли при этой работе  |
|:------------- |:---------------:|
| git init |<span style="color:lime">✓</span>|
| git --version |<span style="color:lime">✓</span>|
| git rm|<span style="color:red">×</span>|
| git status|<span style="color:lime">✓</span>|
| git log|<span style="color:lime">✓</span>|
| git reflog|<span style="color:lime">✓</span>|
| git diff|<span style="color:lime">✓</span>|
| git checkout|<span style="color:lime">✓</span>|
| git add|<span style="color:lime">✓</span>|
| git commit|<span style="color:lime">✓</span>|
| git config|<span style="color:red">×</span>|