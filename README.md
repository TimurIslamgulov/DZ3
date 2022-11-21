
# Продолжаем наше знакомство с Git

Итак у нас есть определенный проект в нашей папочке и нас  все в нем устраивает, но мы решили дополнить его или доработать. Чтобы ничего не испортить в уже существующем файле мы создадим своего рода "черновик", в нашем случае новую ветку.

Для начала пишем команду:

***git branch***

Эта команда показывает, что у нас существует одна основная ветка и называется она ***master***, подсвечена она зеленым и напротив нее стоит флажок.

***git branch(name)*** - эта команда позволяет создать нам новую ветку

Вводим снова команду 

***git branch***

Здесь мы видим. что веточек стало уже две, но флажок находится напротив ветки ***master***. Чтобы перепрыгнуть на новую ветку мы воспользуемся командой 

***git gheckout(name)***

Итак, у нас появилась новая веточка, мы на нее перешли и продолжили работать в нашем "черновике".

Как только мы закончили и нас полностью удовлетворил результат мы обязательно добавляем ***git add(name)*** и сохраняем наши изменения ***git commit -m"(name commit)"***

После этого пришло время добавить наш файл к основному. Для этого мы обязательно переходим на ветку ***master***  при помощи уже известной команды

***git checkout master***

Дфльше производим слияние веток при помощи команды 

***git merge(name_branch)***

Дальше мы вводим команду 

***git log --graph*** и можем увидеть визуально слияние наших веточек.

Иногда бывает такое, что мы случайно и в чистовике и в черновике написали одно и то же, либо где-то что-то не сохранили и тогда при команде ***git merge(name_branch)*** в рабочей области высветится конфликт в виде прямоугольной картинки и описанием, что не так. Внимательно читаем , что написано сверху, выбираем нужный нам вариант и решаем этот конфликт.

После слияния веток образуется автоматический коммит.

Итак, мы слили наши проекты и, созданная нами ранее ветка нам уже не нужна. Мы можем ее удалить при помощи команды

***git branch -d(name)***

# Работа с удаленными репозиториями

***GitHub***- это сервис программы ***Microsoft*** он позволяет чуть более удобнее работать с ***Git*** и настроить удаленную работу с репозиторием

Создаем папку на рабочем столе и открываем ее в ***VS Code*** и, если до этого мы работали с локальным репозиторием при помощи команды ***git init***, то теперьпоработаем с чужим репозиторием.

* Открываем нужный репозиторий и там нажимаем зеленую кнопку ***Code***. Появляется строка с адресом

***https: //...***

Копируем эту строку и переходим в ***VS Code***

* В терминале задаем команду

***git clone https://...***

И ***Git*** скопирует этот удаленный в наш репозиторий

Внутри нашей папки появилась новая папка, в ней скопированно все, что было в репозитории на ***GitHub***

* Чтобы аккуратно поместиться в эту папку. мы используем команду

***cd(name этой папки)***, таким образом мы меняем дирректорию папки и при помощи известных нам команд мы можем посмотреть всю историю работы над этим файлом

Чтобы загрузить наш репозиторий на ***GitHub*** нужно сделать следующее:

* Создаем папку на рабочем столе

* В этой папке создаем наш репозиторий 

***git init***

* Создаем в этой папкефайл, работаем в нем

* Делаем обязательно добавление и сохранение

***git add(name)***

***git commit -m"(name commit)"***

Для того, чтобы залить наш репозиторий на ***GitHub*** нам нужно иметь там аккаунт.

* В аккаунте выбираем строку ***Repositories*** , нажимаем кнопку ***New*** и создаем новый репозиторий. Даем ему название и нажимаем кнопку ***Create Repository***

***GitHub*** нам услужливво подскажет, какие команды нам нужно применить
* Копируем команды

***git remote add origin https: // ...***

***git branch -M main***

***git push -u origin main***

Этими командами мы связываем наш локальный репозиторий с удаленным.

* После этих команд мы обновляем страничку и видим файл, который мы создали находится в ***GitHub***

* Чтобы отправить наши изменения из локального в удаленный репозиторий, необходима команда

***git push***

* Переходим на ***GutHub*** и обновляем страничку и видим, что все наши изменения перенесены

Yuliya Grigoreva, [21.11.2022 19:11]
* Чтобы отправить с ***GitHub*** информацию в локальный репозиторий мы делаем изменения в файле, сохраняем их при помощи кнопки

***Commit Changes***

* Переходим в ***VS Code*** и видим , что изменений не произошло. Вводим команду

***git pull***

Эта команда позволяет "стянуть" с нашего удаленного репозитория все изменения. Также эта команда не только их подгрузит. но и произведет автоматическое слияние.

Если мы хотим поучаствовать в каком-то проекте, но у нас нет доступа к его репозиторию. то можно воспользоваться инструментом 

***Pull Request***

Это запрос на вливание наших измений в проект

* Открываем интерисующий нас проект

* Нажимаем кнопку

***Fork***

Это кнопка делает копию репозитория на наш аккаунт. И теперь у нас так же к нему есть доступ.

* Переходим в наш аккаунт , выбираем эту копию репозитория и копируем его адрес

* Переходим в ***VS Code*** и клонируем ее

***git clone htpps: //...

* Переходим в эту папку и меняем дирректорию

***cd_(name)***

* Создаем новую ветку, чтобы внести изменения

***git branch(name)***

* Переходим на эту ветку

***git checkout(name)***

* Внутри папки создаем новый файл

***README.md***

* Делаем свои изменения. после добавляем и сохраняем их

***git add(name)***

***git add commit -m"(commit name)"***

* Теперь мы напрвляем все эти изменения в наш репозиторий 

***git push***

* Переходим на ***GitHub***, обновляем страницу и видим, что у нас появляется нова ветка и новая кнопка

***Compare & Pull Request***

Она означает сравни и отправь запрос на слияние

* Нажимаем, добавляем комментарий и описание и отправляем дальше при помощи кнопки 

***Creat Pull Request***

Eсли хозяина репозитория устроит мое предложение изменений, то он может залить его в свой проект.







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
