# Инструкция по работе с командами Git

### Команды в GIT и не только (Ветка 2)

**git init** – инициализация (от анг. - initialization) , создание репозитория в папке нахождения файла с которым работаем, команда старта работы. Пример, записи команды в Visual Studio Cod:

* <span style="color:green"> git init</span>

**git add** (добавить) – команда для контроля версии файла (-ов) и отслеживания изменений в файле. Пример, записи команды, обязательно указывается наименование файла с расширением (txt, md или др.):

* <span style="color:green"> git init first.md</span>

**git commit** – фиксация текущей версии файла, используется с комментарием (сопровожительным сообщением), например так:

* <span style="color:green"> git commit </span> 
<span style="color:grey"> –a –m </span> 
<span style="color:blue"> *“first.md внесены новые подпункты”* </span>

**git dif** – отображение (от анг. - difference) разницы между сохраненными версиям (предыдущими сохранениями с помощью команды git commit:

* <span style="color:green"> git dif</span>

**git log** – выводит список всех действий/изменений зафиксированных с помощью git commit с указанием автора и даты внесения изменений:

* <span style="color:green"> git log</span>

**git log –grahp** – выводит список commit в виде графа/дерева

**git checkout** – позволяет переходить между изменениями файла:

* <span style="color:green"> git checkout </span> 
<span style="color:blue"> a3459g </span> 
– возвращение к конкретному commit

* <span style="color:green"> git checkout </span> 
<span style="color:blue"> branch_name </span> 
– возвращение к определенной ветке (
<span style="color:blue"> branch_name </span>
) с изменениями

**git checkout master** – переход обратно к самой последней сохраненной версии файла, ветке

* <span style="color:green"> git checkout master </span> 

**git branch** – выводит на экран список веток которые есть для данного файла

* <span style="color:green"> git branch </span> 

* <span style="color:green"> git branch vetka1 </span> – создание новой ветки

**git clear** – очищение экрана команд, истории команд:

* <span style="color:green"> git claer </span> 

**git merge** – слияние веток, т.е. присоединение к главной ветке master ветки с изменениями:

* <span style="color:green"> git merge vetka1 </span>

**git branch –d  vetka1** – удаление ветки  vetka1

![](End.jpg)

### Дополнительные функции для работы с удаленным репозиторием: 

для внесения изменений в файл .md пользователя с Github, форкните в свой репозиторий необходимый файл на GitHub, затем командой git clone ... (вставляете ссылку файла в git), создаете новую ветку, а после внесения изменений c обязательными коммитами командой git push отправляете изменения обратно на GitHub

для инфо, командой pull request - стягиваем с Github файлы на рабочий бук 


