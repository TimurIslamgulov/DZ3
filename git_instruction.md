# Добавление удаленного репозитория

## Чтобы добавить новый удаленный репозиторий, выполните команду git remote add в терминале в каталоге, в котором хранится репозиторий

### Команда git remote add принимает два аргумента:
* **имя удаленного репозитория, например, origin**
* **URL-адрес удаленного репозитория, например https://github.com/Mgafurov/DZ3.git**

### **Пример:**

**git remote add origin https://github.com/Mgafurov/DZ3.git**

**Set a new remote**

**git remote -v**

**Verify new remote**

**>origin https://github.com/Mgafurov/DZ3.git (fetch)**

**>origin https://github.com/Mgafurov/DZ3.git  (push)**

# Устранение неполадок: удаленный источник уже существует

### **Эта ошибка означает, что вы попытались добавить удаленный репозиторий с именем, которое уже существует в локальном репозитории.**

git remote add origin https://github.com/Mgafurov/DZ3.git

fatal: remote origin already exists.

### **Возможные пути устранения проблемы указаны ниже.**

* **Используйте другое имя для нового удаленного репозитория.**

* **Переименуйте существующий удаленный репозиторий перед добавлением нового удаленного репозитория.Дополнительные сведения см. в разделе [Переименование удаленного репозитория ](https://docs.github.com/ru/get-started/getting-started-with-git/managing-remote-repositories?platform=windows#renaming-a-remote-repository)ниже.**

* **Удалите существующий удаленный репозиторий перед добавлением нового удаленного репозитория.Дополнительные сведения см. в разделе [Удаление удаленного репозитория](https://docs.github.com/ru/get-started/getting-started-with-git/managing-remote-repositories?platform=windows#removing-a-remote-repository) ниже.**

# Изменение URL-адреса удаленного репозитория

### Команда git remote set-url изменяет существующий URL-адрес удаленного репозитория.

**Совет: Сведения о различиях между URL-адресами HTTPS и SSH см. в разделе [Сведения об удаленных репозиториях.](https://docs.github.com/ru/get-started/getting-started-with-git/about-remote-repositories)**

### Команда git remote set-url принимает два аргумента:

* **Имя существующего удаленного репозитория. Например, к распространенным вариантам относятся origin и upstream.**

* **Новый URL-адрес удаленного репозитория. Пример:**

Если вы переходите на протокол HTTPS, URL-адрес может выглядеть так:

https://github.com/Mgafurov/DZ3.git

Если вы переходите на SSH, URL-адрес может выглядеть так:

git@github.com:Mgafurov/DZ3.git

# Переключение удаленных URL-адресов с SSH на HTTPS 

### 1. Откройте GIT Bash.

### 2. Измените текущий рабочий каталог на локальный проект.

### 3. Выведите список существующих удаленных объектов, чтобы получить имя удаленного репозитория, которое требуется изменить.

**git remote -v**

**>origin  git@github.com:Mgafurov/DZ3.git (fetch)**

**>origin  git@github.com:Mgafurov/DZ3.git (push)**

### 4. Переключите URL-адрес удаленного репозитория с SSH на HTTPS, выполнив команду git remote set-url.

**git remote set-url origin https://github.com/Mgafurov/DZ3.git**

### 5. Убедитесь, что URL-адрес удаленного репозитория изменен.

**git remote -v**

**Verify new remote URL**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

### При следующем выполнении команд git fetch, git pull и git push для удаленного репозитория вам будет предложено указать имя пользователя и пароль GitHub. Когда Git предложит ввести пароль, введите personal access token. Кроме того, можно использовать вспомогательное средство учетных данных, например [диспетчер учетных данных Git.](https://github.com/git-ecosystem/git-credential-manager/blob/main/README.md) Проверка подлинности на основе пароля для Git была удалена в пользу более безопасных методов проверки подлинности. Дополнительные сведения см. в разделе [Создание личного маркера доступа.](https://docs.github.com/ru/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token)

### Вы можете [использовать вспомогатель учетных данных ,](https://docs.github.com/ru/get-started/getting-started-with-git/caching-your-github-credentials-in-git) чтобы Git запоминал ваше имя пользователя GitHub и personal access token при каждом разговоре с GitHub.

# Переключение удаленных URL-адресов с HTTPS на SSH

### 1. Откройте GIT Bash.
### 2. Измените текущий рабочий каталог на локальный проект
### 3. Выведите список существующих удаленных объектов, чтобы получить имя удаленного репозитория, которое требуется изменить.

**git remote -v**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

### 4. Переключите URL-адрес удаленного репозитория с HTTPS на SSH, выполнив команду git remote set-url.

**git@github.com:Mgafurov/DZ3.git**

### 5. Убедитесь, что URL-адрес удаленного репозитория изменен.

**git remote -v**

**Verify new remote URL**

**> origin  git@github.com:Mgafurov/DZ3.git (fetch)**

**> origin  git@github.com:Mgafurov/DZ3.git (push)**

# Устранение неполадок: удаленный репозиторий "[имя]" отсутствует

## **Эта ошибка означает, что удаленного репозитория, который вы пытались изменить, не существует:**

**git remote set-url sofake https://github.com/octocat/Spoon-Knife**

**> fatal: No such remote 'sofake'**

Убедитесь, что вы правильно указали имя удаленного репозитория.

# Переименование удаленного репозитория 

## Используйте команду git remote rename для переименования существующего удаленного репозитория.

### **Команда git remote rename принимает два аргумента:**

* **имя существующего удаленного репозитория, например, origin;**
* **новое имя удаленного репозитория, например, destination.**

## Пример переименования удаленного репозитория

**В этих примерах предполагается, что [клонирование выполняется с помощью HTTPS ](https://docs.github.com/ru/get-started/getting-started-with-git/about-remote-repositories#cloning-with-https-urls) (это рекомендуемый вариант).**

**git remote -v**

**View existing remotes**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

**git remote rename origin destination**

**Change remote name from 'origin' to 'destination'**

**git remote -v**

**Verify remote's new name**

**> destination  https://github.com/Mgafurov/DZ3.git (fetch)**

**> destination  https://github.com/Mgafurov/DZ3.git (push)**

# Устранение неполадок: не удалось переименовать раздел конфигурации "remote.[старое имя]" в "remote.[новое имя]"

## Эта ошибка означает, что удаленного репозитория с указанным старым именем не существует.

### **Вы можете проверить существующие удаленные репозитории, выполнив команду git remote -v:**

**git remote -v**

**View existing remotes**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

# Устранение неполадок: удаленный репозиторий [новое имя] уже существует 

### Эта ошибка означает, что удаленный репозиторий с именем, которое вы хотите использовать, уже существует. Чтобы решить эту проблему, используйте другое имя удаленного репозитория или переименуйте имеющийся удаленный репозиторий.

# Удаление удаленного репозитория

## Чтобы удалить удаленный URL-адрес из репозитория, используйте команду **git remote rm**

### Команда **git remote rm** принимает один аргумент:

* имя удаленного репозитория, например, **destination**

### При удалении удаленного URL-адреса из репозитория выполняется только отмена привязки для локальных и удаленных репозиториев. Сам удаленный репозиторий не удаляется.

## Пример удаления удаленного репозитория

### В этих примерах предполагается, что [клонирование выполняется с помощью HTTPS ](https://docs.github.com/ru/get-started/getting-started-with-git/about-remote-repositories#cloning-with-https-urls) (это рекомендуемый вариант).

**git remote -v**

**View current remotes**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

**> destination  https://github.com/Mgafurov/DZ3.git (fetch)**

**> destination  https://github.com/Mgafurov/DZ3.git (push)**

**git remote rm destination**

**Remove remote**

**git remote -v**

**Verify it's gone**

**> origin  https://github.com/Mgafurov/DZ3.git (fetch)**

**> origin  https://github.com/Mgafurov/DZ3.git (push)**

### **Примечание. Команда git remote rm не удаляет удаленный репозиторий с сервера. Она просто удаляет удаленный репозиторий и его ссылки из локального репозитория.**

# Устранение неполадок. Не удалось удалить раздел конфигурации "remote.[имя]" 

### Эта ошибка означает, что удаленного репозитория, который вы пытались удалить, не существует:

**git remote rm sofake**

**> error: Could not remove config section 'remote.sofake'**

### Убедитесь, что вы правильно указали имя удаленного репозитория.

# Дополнительные материалы 
* **["Работа с удаленными репозиториями" из книги Pro Git](https://git-scm.com/book/en/v2/Git-Basics-Working-with-Remotes)**