## Заголовок
<span style="color:orange">  ***Инструкция по работе с коммандами Git***</span>


# <span style="color:orange">  **Git**</span>
Это программа ведет контроль версий проекта
Сохраняет не файлы, а разницу между ними

# <span style="color:orange">  **Комманды Git**</span>
<span style="color:Yellow">  **Git add**</span>

Команда <span style="color:Yellow">  *git add*</span>
 добавляет содержимое рабочей директории в индекс для последующего коммита. По умолчанию Команда <span style="color:Yellow">  *git commit*</span> использует лишь этот индекс, так что вы можете использовать Команда <span style="color:Yellow">  *git add*</span> для сборки слепка вашего следующего коммита.

<span style="color:Yellow">  **Git status**</span>

Команда <span style="color:Yellow">  *git status*</span> показывает состояния файлов в рабочей директории и индексе: какие файлы изменены, но не добавлены в индекс; какие ожидают коммита в индексе. Вдобавок к этому выводятся подсказки о том, как изменить состояние файлов.

<span style="color:Yellow">  **Git diff**</span>

Команда <span style="color:Yellow">  *git diff*</span> используется для вычисления разницы между любыми двумя Git деревьями. Это может быть разница между вашей рабочей директорией и индексом (собственно <span style="color:Yellow">  *git diff*</span> ), разница между индексом и последним коммитом (<span style="color:Yellow">  *git diff --staged*</span> ), или между любыми двумя коммитами (<span style="color:Yellow">  *git diff master branchB*</span> ).

<span style="color:Yellow">  **Git commit**</span>

Команда <span style="color:Yellow">  *git commit*</span> берёт все данные, добавленные в индекс с помощью <span style="color:Yellow">  **Git add**</span>, и сохраняет их слепок во внутренней базе данных, а затем сдвигает указатель текущей ветки на этот слепок.

<span style="color:Yellow">  **Git reset**</span>

Команда <span style="color:Yellow">  *git reset*</span>, как можно догадаться из названия, используется в основном для отмены изменений. Она изменяет указатель Команда <span style="color:Yellow">  *HEAD*</span> и, опционально, состояние индекса. Также эта команда может изменить файлы в рабочей директории при использовании параметра Команда <span style="color:Yellow">  *--hard*</span>, что может привести к потере наработок при неправильном использовании, так что убедитесь в серьёзности своих намерений прежде чем использовать его.

<span style="color:Yellow">  **Git checkout**</span>

Команда <span style="color:Yellow">  *git checkout*</span> используется для переключения веток и выгрузки их содержимого в рабочую директорию.

<span style="color:Yellow">  **Git log**</span>

Команда <span style="color:Yellow">  *git log*</span> используется для просмотра истории коммитов, начиная с самого свежего и уходя к истокам проекта. По умолчанию, она показывает лишь историю текущей ветки, но может быть настроена на вывод истории других, даже нескольких сразу, веток. Также её можно использовать для просмотра различий между ветками на уровне коммитов.

<span style="color:Yellow">  **Git stash**</span>

Команда <span style="color:Yellow">  *git stash*</span> используется для временного сохранения всех незакоммиченных изменений для очистки рабочей директории без необходимости коммитить незавершённую работу в новую ветку.

<span style="color:Yellow">  **Git tag**</span>

Команда <span style="color:Yellow">  *git tag*</span> используется для задания постоянной метки на какой-либо момент в истории проекта. Обычно она используется для релизов.

<span style="color:Yellow">  **Оффициальная документация git**</span>

*https://git-scm.com/docs/user-manual*

![Git logo](https://host-base.ru/wp-content/uploads/1/7/c/17c86d4f862234bbc3a2f0a432a9f850.jpeg)