<style>
green  { font-weight: bold; color: darkgreen }
yellow {font-size: 16px; color: yellow }
</style>

# Справка по командам контроля версий в Git

| Команда        |Синтаксис         |     Описание                                                                |
|----------------|------------------|-----------------------------------------------------------------------------|
| <yellow>clear</yellow>          |clear             |Очищает окно терминала                                                       |
| <yellow>q</yellow>              |q                 |Выходит из меню, которое оканчивается (END)                                  |
| <yellow>version</yellow>        |git --version     |Проверяет установлена ли программа Git и показывает какой она версии         |
| <yellow>init</yellow>           |git init          |После этой команды запускается механизм контроля версий Git для текущей папки|
| <yellow>add</yellow>            |git add имя_файла.расширение|Добавляет указанный файл в пул файлов, которые будут обработаны командой commit|
| <yellow>add .</yellow>          |git add .         |Добавляет все файлы текущей папки в пул файлов, которые будут обработаны командой commit|
| <yellow>commit -m</yellow>      |git commit -m "abc"|Совершает фиксацию текущей версии файлов в текущей папке и добавляет к этой фиксации комментарий abc</yellow>|
| <yellow>commit -am</yellow>     |git commit -am "abc"|Добавляет в фиксацию все файлы, которые добавлялись в предыдущии фиксации, затем совершает саму фиксацию по этим файлам и добавляет к ней комментарий abc|
| <yellow>log</yellow>            |git log|Выводит подробную информацию о нескольких последних версиях, комментариях, времени логирования|
|<yellow>reflog</yellow>          |git reflog           |Выводит краткую информацию по всем версиям|
|<yellow>log --oneline</yellow>   |git log --oneline    |То же самое, что git reflog               |
|<yellow>dif</yellow>             |git dif    |Показывает разницу между текущим сохранением и последней сохраненной версией |
|<yellow>dif aaaa bbbb</yellow>   |git dif aaaa bbbb    |Показывает разницу между версиями, начинающимися на aaaa и на bbbb|
|<yellow>checkout a4fg</yellow>   |git checkout aaaa      |Переходим в версию, начинающуюся на aaaa               |
|<yellow>checkout master</yellow> |git checkout master    |Переходит в последнюю версию               |
|<yellow>clone</yellow> |git clone <ССЫЛКА НА РЕПОЗИТОРИЙ НА GITHUB>    |Создает локальную копию репозитория, находящегося по ссылке на GitHub               |
|<yellow>push</yellow> |git push -u origin main     |Загружает все текущие закоммиченные изменения в репозиторий на GitHub               |
|<yellow>pull</yellow> |git pull    |Скачивает все последние закоммиченные изменения из репозитория на GitHub               |