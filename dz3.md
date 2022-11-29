# Домашнее задание 1

1. Для начала работы с ***git*** в конкретной папке, нужно использовать команду *git init*
    >![пример init](/version_control/git_init.png)
2. Команды *git add file.name* и *git add .* добавляют к отслеживанию конкретный файл или все файлы в репозитории соответственно
    >![пример add](/version_control/git_add.png)

    >![пример add .](/version_control/git_add_..png)
3. Для записи конкретного изменения в файле используем команду *git commit -am "НазваниеИзменения"* 
    >![пример commit](/version_control/git_commit.png)
4. Команда *git diff номер1 номер2* призвана вывести разницу между изменениями в файле под номером1 и номером2 
    >![пример diff](/version_control/git_diff.png)
5. Для вывода списка изменений нам известно пара команд:
    * *git log*
        >![пример log](/version_control/git_log.png)
    * *git reflog*
        >![пример reflog](/version_control/git_reflog.png)
6. Чтобы перейти к изменению с каким-то номером, нужно использовать команду *git checkout номер1*
    >![пример checkout](/version_control/git_checkout.png)
7. Команда *git rm file.name* удалит файл ~~из отслеживания~~
    >![пример rm](/version_control/git_rm.png)
8. Команда *git push* отправляет локальные данные в github
9. *git pull* забирает данные из github в локальный репозиторий
10. *git pull request* делает запрос на изменение 