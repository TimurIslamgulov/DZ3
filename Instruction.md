Инструкция по работе с Git

> [!Внимание]
> Все операции производятся в Терминале.


1. Инициализация (**init**)
2. Проверка статуса (**status**)
3. Добавление файла в git (**add**)
4. Сохранение версии файлов (**commit**)
5. Сравнение версий (**diff**)
6. Проверка истории изменений (**log**)
7. Переход в нужную версию (**checkout**)
8. Создание ветки (__branch__)
9. Слияние ветки (__merge__)
10. Удаление ветки (__branch -d__)
11. Копирование с локальной машины на GitHub (__push__)
12. Загрузка изменений с GitHub (__pull__)


## 1. Для инициализации контроля версии необходимо перейти в нужную папку:
%cd \myFolder\gitFolder

Запустить команду инициализации:
* % git init
> Initialized empty Git repository in /Users/Ivan/myFolder/gitFolder/.git/

## 2. Проверить статус:
* % git status
> On branch master
> nothing to commit, working tree clean


## 3. Создать в папке рабочий файл:
* % echo > filename.txt

###  Добавить все файлы в систему контроля версий (*делается один раз для файла*):
* % git add -all

## 4. Зафиксировать изменения:
* % git commit -a -m "my first commit"
> [master (root-commit) 87e0a19] my first commit
>  1 file changed, 1 insertion(+)

## 5. Сравнить с текущей версией (*при изменении файла*):
* % git diff
> diff --git a/filename.txt b/filename.txt
> index 9daeafb..1e1ee87 100644
> --- a/first.txt
> +++ b/first.txt
> @@ -1 +1,2 @@
>  test
> +asdfadf

## 6. Посмотреть изменения зафиксированные в git:
* % git log
> commit 27694149528f56cb9c58806ec4ff42982ff00891 (HEAD ->  master)
> Author: Author <Authorh@mail.ru>
> Date:   Tue Sep 27 20:20:20 2022 +0300
>     my first commit

## 7. Перейти в сохраненное состояние:
* % git checkout 2769
> Note: switching to '2769'.
> 
> You are in 'detached HEAD' state. You can look around, make > experimental
> changes and commit them, and you can discard any commits you > make in this
> state without impacting any branches by switching back to a branch.
> 
> If you want to create a new branch to retain commits you  create, you may
> do so (now or later) by using -c with the switch command.  Example:
> 
>   git switch -c <new-branch-name>
> 
> Or undo this operation with:
> git
>   git switch -
> 
> Turn off this advice by setting config variable advice. detachedHead to false
> 
> HEAD is now at 2769414 my first commit

* % git checkout reviewer

> M       Instruction.md

> Switched to branch 'reviewer'


## 8. Создание ветки

* % git branch student
* % git branch
> *master
>
> student


## 9. Слияние ветки
* % git merge student
> Auto-merging conflict.md
CONFLICT (content): Merge conflict in conflict.md
Automatic merge failed; fix conflicts and then commit the result.

## 10. Удаление ветки (__branch -d__)
* % git branch -d student
> Deleted branch student (was 6fdd9cc).

## 11. Копирование с локальной машины на GitHub
на локальной машине
* % git init
* % git commit -a -m "initial commit"
в GitHub создать репозиторий вручную
потом на локальной машине
* % git remote add origin https://github.com/Rusttm/Geekbrains.git
* % git branch -M main
* % git push -u origin main

## 12. Загрузка изменений с GitHub
* % git pull



