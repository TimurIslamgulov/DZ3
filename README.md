# Инструкция для работы с Git и удалёнными репозиториями

## Что такое Git?
Git - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.
## Подготовка репозитория
Для создания репозитория необходимо выполнить команду *git init* в папке с репозиторием и у Вас создаться репозиторий (появится скрытая папка .git)

## Создание коммитов

### Git add
Для добавления измений в коммит используется команда *git add*. Чтобы использовать команду *git add* напишите *git add <имя файла>*

### Просмотр состояния репозитория
Для того, чтобы посмотреть состояние репозитория используется команда *git status*. Для этого необходимов папке с репозиторием написать *git status*, и Вы увидите были ли измения в файлах, или их не было.

### Создание коммитов
Для того, чтобы создать коммит(сохранение) необходимо выполнить команду *git commit*. Выполняется она так: *git commit -m "<сообщение к коммиту>*. Все файлы для коммита должны быть **ДОБАВЛЕНЫ** и сообщение к коммиту писать **ОБЯЗАТЕЛЬНО**.

## Перемещение между сохранениями
Для того, чтобы перемещаться между коммитами, используется команда *git checkout*. Используется она в папке с репозиторием следующим образом: *git checkout <номер коммита>*

## Журнал изменений
Для того, чтобы посмотреть все сделанные изменения в репозитории, используется команда *git log*. Для этого достаточно выполнить команду *git log* в папке с репозиторием.

## Ветки в Git

### Создание ветки
Для того, чтобы создать ветку, используется команда *git branch*. Делается это следующим образом в папке с репозиторием: *git branch <название новой ветки>*

## Слияние веток
Для того чтобы дабавить ветку в текущую ветку используется команда *git merge*

## Удаление веток
Для удаления ветки ввести команду *git branch -d 'name branch'*

## Работа с удаленными репозиториями. Скачивание из текущего репозитория и слияние со своей версией
Освоить работу с удаленными репозиториями, которые находятся не на локальной, а на удаленной машине, например, на сервере.
Копировать внешний репозиторий на свой ПК можно командой *git clone*.
Команда *git clone* составная: она не толькозагружает все изменения, но и пытается слить все ветки на локальном компьютере и в удаленном репозитории.
*git pull* -эта команда позволяет скачать все из текущего репозитория и автоматически сделать merge с нашей версией.
Отправить свою версию репозитория во внешний репозиторий поможет команда *git push*. При первом её использовании нужна авторизация.
Эта команда позволяет отправить нашу версию репозитория на внешний
репозиторий. ТРЕБУЕТ АВТОРИЗАЦИИ на внешнем репозитории.

## Как настроить совместную работу
1. Создать аккаунт на GitHub.com
2. Создать локальный репозиторий
3. “Подружить” ваш локальный и удалённый репозитории. 
*GitHub при создании нового репозитория подскажет, как это можно сделать*
4. Отправить (*push*) ваш локальный репозиторий в удалённый (*на GitHub*), при этом, возможно, вам нужно будет авторизоваться на удалённом репозитории
5. Провести изменения “с другого компьютера”
6. Выкачать (*pull*) актуальное состояние из удалённого репозитория

**pull request**

Углубляемся в контроль версий
* команда для предложения изменений
* запрос на вливание изменений в репозиторий

 В больших компаниях один ответственный за проект создает аккаунт. Другие пользователи дают команду pull request. Предлагать изменения на GitHub нужно в отдельной ветке. Сначала пользователь копирует репозиторий на свой компьютер, делает fork репозитория затем клонирует версию на своём ПК, создаёт ветку с предлагаемыми изменениями, отправляет изменения командой push в свой аккаунт на GitHub и даёт команду pull request. 

## Как сделать pull request
* Делаем   (ответвление) репозитория *fork*
* Делаем *git clone*   версии репозитория СВОЕЙ
* Создаем новую ветку и в НЕЕ вносим свои изменения
* Фиксируем изменения (делаем коммиты)
* Отправляем свою версию в свой *GitHub*
* На сайте *GitHub* нажимаем кнопку *pull request*