# Git. Инструкция

### Команды:

* **git init** - превращает любую папку в Git репозиторий

* **git add** - добавляет файлу версионность в локальном репозитории

* **git commit -m "message about changes"** - фиксирует изменения
>*Over time, commits should tell a story of the history of your repository and how it came to be the way that it currently is*

*Источник: [Git Guides](https://github.com/git-guides)*

* **git status** - посмотреть текущее состояние рабочего каталога Git и промежуточной области

* **git log** - посмотреть журнал изменений

* **git diff** - посмотреть изменения между коммитами

### Еще команды:

* **git reflog** - посмотреть все коммиты

* **git commit -am «message»** - объединение команды add и commit для уже отслеживаемого файла

* **git add .** - добавить все файлы из папки в отслеживание

* **git diff 9494 mfj4** - сравнение двух коммитов (после "diff" первые четыре символа первого коммита и через пробел - первые четыре второго)

### Работа с ветками:

* **git branch** - узнать текущую ветку

* **git branch branch1** - создать новую ветку

* **git checkout branch1** - перейти к новой ветке

* **git checkout main** - перейти на ветку мастер (на главную ветку) 
***!мержить надо с нее***

* **git merge branch1** - слить главную ветку с веткой branch1

* **git log --graph** - графически показать слияние веток

* **git branch -d branch1** - удалить ветку

### Еще команды:

* **git checkout -b branch2** - создать ветку и сразу перейти в нее

### Работа с GitHub:

1. Создать репозиторий на GitHub и скопировать ссылку на него
2. git remote add origin https://github.com/DianaEnginoeva/geekbrains.git
3. git branch -M main  
4. git push -u origin main 

* **git push** - отправить на гитхаб измененные версии уже добавленных файлов
* **git pull** - синхронизировать текущие локальные версии с изменениями на гитхабе

#### Как сделать pull request к чужому репозиторию на GitHub:

1. Зайти на нужный репозиторий, сделать форк к нему
2. Скопировать ссылку на этот репозиторий (уже в своем гитхабе)
3. git clone https://github.com/DianaEnginoeva/DZ3.git
4. cd DZ3
5. git checkout -b homework-3
6. Меняем файлы, коммитим
7. git push —set-upstream origin homework-3
8. Проверить пуш (в ветке, которую создали)
9. На главной репозитория нажать кнопку compare&pull request, написать коммент, создать пул реквест

![This is a clue](img/pullrequest.png)

####  Время шутить!

![This is the mem](https://cs8.pikabu.ru/post_img/2018/02/16/7/1518781717140773572.jpg)
![This is the mem2](img/mem2.jpeg)
