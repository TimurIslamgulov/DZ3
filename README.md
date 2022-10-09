# Git 
- это консольная утилита, для отслеживания и ведения истории изменения файлов, в вашем проекте. Чаще всего его используют для кода, но можно и для других файлов. Например, для картинок - полезно для дизайнеров.
С помощью Git-a вы можете откатить свой проект до более старой версии, сравнивать, анализировать или сливать свои изменения в репозиторий.

- Репозиторием называют хранилище вашего кода и историю его изменений. Git работает локально и все ваши репозитории хранятся в определенных папках на жестком диске.

Так же ваши репозитории можно хранить и в интернете. Обычно для этого используют три сервиса:

### GitHub

### Bitbucket

### GitLab

- Каждая точка сохранения вашего проекта носит название коммит (commit). У каждого commit-a есть hash (уникальный id) и комментарий. Из таких commit-ов собирается ветка. Ветка - это история изменений. У каждой ветки есть свое название. Репозиторий может содержать в себе несколько веток, которые создаются из других веток или вливаются в них.
# Основные команды Git #


- git init – инициализация локального репозитория*

- git status – получить информацию от git о его текущем состоянии

- git add – добавить файл или файлы к следующему коммиту

- git commit -m “message” – создание коммита.

- git log – вывод на экран истории всех коммитов с их хеш-кодами

- git checkout – переход от одного коммита к другому

- git checkout master – вернуться к актуальному состоянию и продолжить работу

- git diff – увидеть разницу между текущим файлом и закоммиченным файлом

- git branch – посмотреть список веток в репозитории

- git branch <название ветки> – создать новую ветку

- git checkout <название ветки> – переход к другой ветке

- git branch -d <название ветки> – удалить ветку

- git clone <url-адрес репозитория> – клонирование внешнего репозитория на
локальный ПК

- git pull – получение изменений и слияние с локальной версией

- git push – отправляет локальную версию репозитория на внешний

# Авторизация в GitHub

- New – Создаём репозиторий

- HTTPS – переключаем “Quick setup” для доступа по HTTPS

- git remote add origin … – добавляем адрес удалённого репозитория

- git branch -M main – меняем название основной ветки

- git log – вывод на экран истории всех коммитов с их хеш-кодами

- git push -u origin main – отправляем изменения на удалённый репозиторий




# Синтаксис языка Markdown
# Выделение текста
## Заголовок - выделение заголовков. Количество символов "#" задает уровень заголовка (поддерживается 6 уровней).
- = или - подчеркиванием этими символами (не менее 3 подряд) выделяют заголовки первого (=) и второго ("-") уровней.
 
- **Полужирное начертание** или _Полужирное начертание_

 - *Курсивное начертание* или _Курсивное начертание_

 - ***Полужирное курсивное начертание***
 
 - ~~Зачеркнутый текст~~

 * Строка - ненумерованные списки, символ "*" в начале строки

 1, 2, 3, ... - нумерованные списки

 * Блоки цитирования создаются с помощью символа ">". 
 
 Например: 
 > Падает тот, кто бежит. Тот, кто ползет, не падает.

 * Базовый синтаксис Markdown для внедрения изображения: 
 
-  Чтобы вставить изображение в текст, достаточно написать следующее:

!["текст обозначения"](vylkan.jpg)

если не соблюдать порядок выставления обозначений, картинка не прогрузится






























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
