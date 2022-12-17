# **Инструкция по работе с Git**

## Предварительнная настройка Git

Чтобы "представиться" программе git нужно ввести команды:

    git config --global user.name "Ваше имя"
    git congig --global user.email "ваш е-мейл"

# Создание репозитория

Чтобы инициализировать новый репозиторий нужно ввести:

    git init

## Добавление в индекс

Чтобы добавить изменения в индекс (для фиксации в  следующем коммите) нужно ввести командуЖ

    git add <имя файла>

## Фиксация изменений

Чтобы зафиксировать изменения, добавленные в индекс нужно ввести команду 

    git commit

Появится окно текстового редактора (например, nano или vim), в котором нужно ввести комментарий к коммиту на английском языке.

Если же вы не хотите писать изменение в текстовом редакторе, можно воспользоваться командой

    git commit -m "сообщение"

Чтобы автоматически индексировать каждый уже отслеживаемый на момент коммита файл, позволяя вам обойтись без git add, воспользуйтесь командой

    git commit -a

Добавьте -m для передачи сообщения коммита без запуска полноценного редактора

    git commit -am "сообщение"

## Просмотр истории коммитов

Чтобы посмотреть историю коммитов. Одним из основных и наиболее мощных инструментов для этого является команда

    git log

Есть необходимость вывести все в одну линию? Используйте команду

    git log --oneline

Команда для нахождения изменений между любыми двумя точками в истории вашего проекта, это:

    git diff
    

Чтобы перемещаться между ветками, созданными командой **git branch**, воспользуйтесь командой:

    git checkout'hash комиита'
    git checkout master


# Seminar 2. Branches 

## 1. Create new brach:

First, put command with the name of your new brach:

    git branch jun1

Secondly, to move to the branch you need, write command and the name of the branch:

    git checkout nameOfTheBranch

OR! You can use command that will create and move you to the newly created branch by adding **-b**:

    git checkout -b nameOfTheBranch

## 2. Merge branch

To merge all added and commited info from your new branch to master branch you need to:

First, checkout ot the master branch:

    git checkout master

Secondly, merge:

    git merge nameOfTheCreatedBranch

## 3 Creating conflict and resolve it 

Conflict can be created if branches have different code in same lines and you try to merge it.
To resolve conflict use:

    CTRL+SHIFT+G

Delete and/or save changes 

## 4 Delete the branch

After merging all info and resolving conflict, you may want to delete the branch. You can do ot by the command:

    git branch -d jun1

To test it:

    git branch


# Seminar 3. Remote repo

First of all you need to synchronize your VS with github. In the left bottom corner in VS you will see person icon, where you can set it to be synchronized with github **(turn on setting sync -> Sign in & Turn on -> Sign with github -> Authorize VS Code -> Open)**.

After you successfully synchronize your VS (or other IDE) with github you can pull, push and clone remote repositories.


You need to create new repo in your github. After you need to enter commands below in your VS (they will be shown in github as soon as you click on "New Repository"):

    git remote add origin https://github.com/YourGitName/NameOfYourRepo.git
    git branch -M main
    git push -u origin main


