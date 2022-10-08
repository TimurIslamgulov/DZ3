

теперь само ДЗ, я старался и придумывал


1 уровень - обязательный:

    Дополнить файл с инструкцией по работе с Git и направить pull request в  мой репозиторий, Файл с инструкцией необходимо дополнить информацией о работе с  удаленными репозиториями. В системе подгрузить скриншот отправленного pull request.


2 уровень - рекомендуемый:

    Дополнить pull request своей визитной карточкой гитхаба readme.md. Постарайтесь написать свои мечты и желания, которые хотите реализовать с помощью новой профессии)) чтоб путеводная звезда горела и помогала учиться.

3 уровень - (по желанию) hardcore. 

    Перед вами непростая и интересная задача. Попробуйте сделать блок-схему и если получится, то крепите к pull request.


Эта задача, по слухам, предлагается на собеседовании в Гугл! дерзайте, попробуйте свои силы!

![сама задача](task.png)

https://stepik.org/lesson/3369/step/11?unit=952

ниже будут приведены комментарии людей

![коммент1](kom1.png)

![коммент1](kom4.png)

![коммент1](kom3.png)

![коммент1](kom5.png)
![коммент1](kom2.png)


кстати несколько вариантов вставки картинок , кто - то давно интересовался

https://ask-dev.ru/info/12384/add-images-to-readmemd-on-github

## Инструкция по работе с удаленным репозиторием

### Введение

Сущесвует несколько сервисов для организации работ удаленных репозиториев.
Одим из самых популярных является GitHub, на нем мы и будем работать.

## Команды для работы с удаленными репозиториями:

1. git clone http_адрес_репозитория - загружает все изменения и пытается слить все ветки на локальном компьютере и в удаленном репозитории
2. git push - отправляет нашу локальную версию во внешний репозиторий (при первом испольховании обяательна регистрация на GitHub).
3. git pull - скачивает все из внешнего репозитория и делает merge с нашей версией

# Пошаговая инструкция как создать совместную работу:
1. Создать аккаунт на GitHub
2. Создать локальный репозиторий
3. "Подружить" наш локальный и внешний репозитории (GitHub при создании нового репозитория подскажет как это сделать)
4. Отправить через команду push наш локальный репозиторий на удаленный, при этом мы долны быть зарегистрированы на GitHub
5. Провести изменения с "другого компьютера", имеется ввиду зайти на удаленный репозиторий и внести в него изменения
6. Через команду pull выкачать последние данные с удаленного репозитория на наш локальный 

# Команда pull requet

Данная команда нужна для предложения изменений в чужой удаленный репозиторий и для запроса на вливание изменений в репозиторий

Как сделать pull request:
- делаем fork (ответвление) репозитория на сайте github
- делаем git clone своей версии репозитория
- создаем новую ветку и в нее вносим изменения
- фиксируем изменения через коммиты
- отправляем свою версию на github через push
- на сайте github нажимаем на кнопку Pull request