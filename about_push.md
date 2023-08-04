### Инструкция по работе с удаленными репозиториями.

##  Добавление удаленного репозитория:
Чтобы добавить новый удаленный репозиторий, выполните команду _git remote add_ в терминале в каталоге, в котором хранится репозиторий.

Команда _git remote add_ принимает два аргумента:

имя удаленного репозитория, например, _origin_;
URL-адрес удаленного репозитория, например, https://github.com/OWNER/REPOSITORY.git.

* Пример:

>_git remote add origin https://github.com/OWNER/REPOSITORY.git
Set a new remote_

>_git remote -v
Verify new remote
origin  https://github.com/OWNER/REPOSITORY.git (fetch)
origin  https://github.com/OWNER/REPOSITORY.git (push)_

# Устранение неполадок: удаленный источник уже существует

Эта ошибка означает, что вы попытались добавить удаленный репозиторий с именем, которое уже существует в локальном репозитории.

>_git remote add origin https://github.com/octocat/Spoon-Knife.git_

> _fatal: remote origin already exists._

__Возможные пути устранения проблемы указаны ниже.__

* Используйте другое имя для нового удаленного репозитория.
* Переименуйте существующий удаленный репозиторий перед добавлением нового удаленного репозитория. Дополнительные сведения см. в разделе Переименование удаленного репозитория ниже.
* Удалите существующий удаленный репозиторий перед добавлением нового удаленного репозитория. Дополнительные сведения см. в разделе Удаление удаленного репозитория ниже.

## Изменение URL-адреса удаленного репозитория

Команда _git remote set-url_ изменяет существующий URL-адрес удаленного репозитория.

__Команда _git remote set-url_ принимает два аргумента:__

* Имя существующего удаленного репозитория. Например, к распространенным вариантам относятся origin и upstream.

* Новый URL-адрес удаленного репозитория. Пример:

Если вы переходите на протокол HTTPS, URL-адрес может выглядеть так:
https://github.com/OWNER/REPOSITORY.git

Если вы переходите на SSH, URL-адрес может выглядеть так:
git@github.com:OWNER/REPOSITORY.git

## Переименование удаленного репозитория

Используйте команду _git remote rename для_ переименования существующего удаленного репозитория.

Команда _git remote rename _принимает два аргумента:

* имя существующего удаленного репозитория, например, origin;
* новое имя удаленного репозитория, например, destination.
Пример переименования удаленного репозитория

В этих примерах предполагается, что клонирование выполняется с помощью HTTPS (это рекомендуемый вариант).

> git remote -v
View existing remotes
origin  https://github.com/OWNER/REPOSITORY.git (fetch)
origin  https://github.com/OWNER/REPOSITORY.git (push)
git remote rename origin destination
Change remote name from 'origin' to 'destination'
git remote -v
Verify remote's new name
destination  https://github.com/OWNER/REPOSITORY.git (fetch)
destination  https://github.com/OWNER/REPOSITORY.git (push)

## Удаление удаленного репозитория

Чтобы удалить удаленный URL-адрес из репозитория, используйте команду _git remote rm_.

Команда _git remote rm_ принимает один аргумент:

* имя удаленного репозитория, например, _destination_.

При удалении удаленного URL-адреса из репозитория выполняется только отмена привязки для локальных и удаленных репозиториев. Сам удаленный репозиторий не удаляется.

Пример удаления удаленного репозитория

В этих примерах предполагается, что клонирование выполняется с помощью HTTPS (это рекомендуемый вариант).

>git remote -v
View current remotes
> origin  https://github.com/OWNER/REPOSITORY.git (fetch)
> origin  https://github.com/OWNER/REPOSITORY.git (push)
> destination  https://github.com/FORKER/REPOSITORY.git (fetch)
> destination  https://github.com/FORKER/REPOSITORY.git (push)
>git remote rm destination
Remove remote
git remote -v
Verify it's gone
> origin  https://github.com/OWNER/REPOSITORY.git (fetch)
> origin  https://github.com/OWNER/REPOSITORY.git (push)

Примечание. Команда _git remote rm_ не удаляет удаленный репозиторий с сервера. Она просто удаляет удаленный репозиторий и его ссылки из локального репозитория.