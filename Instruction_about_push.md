# Инструкция о работе с удаленными репозиториями

## Чтобы залить свой репозиторий на GitHub нужно:

1. Залогиниться и нажать "New repository", придумать имя и нажать "Create repository"

2. Выполнить команды:

        git remote add origin link    
        git branch -M main
        git push -u origin main

3. Затем залить локальный репозиторий на удаленный

        git push

# Чтобы предложить изменения в чужом репозитории нужно:

1. Открыть чужой репозиторий.

2. Нажать на вилку (Fork), потом [<span style="color:green">Create fork</span>] - (_чужой репозиторий скопируется на Ваш удаленный_)

3. [<span style="color:green">Code</span>] - Скопировать HTTPS ссылку (link)

4. (У себя на пк предварительно лучше создать папку).

* В VScode через терминал вводим следующее:

        git init
        git clone link
        git cd name_folder

5. В ветке <span style="color:yellow">main</span> ничего не меняем, создаем <span style="color:red">СВОЮ</span> ветку:

        git checkout -b branch_name

6. Проделываем свои изменения затем сохраняем командой:

        git commit -am "comment"

7. Отправляем изменения локального репозитория на свой удаленный:

        git push

8. Проверяем на GitHub появилась ли Ваша новая ветка с изменениями и отправляем Автору на рассмотрение изменений: [<span style="color:green">Compare & pull request</span>].


    