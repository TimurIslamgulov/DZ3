>**This is ia quick user guide for beginners to basics of Git. It is a live document and it being updated regularly**
<p> </p>

# About Git

Git is one of the most popular solutions in market for managing the versions of files in complex projects, whether performed by one person or multiple team members. 
<p> </p>

# Download and install

Download and install the latest version of Git using the following link: 
> [Download Git](https://git-scm.com/downloads)
<p> </p>

While it is possible to manage a project through Git interface itself, it is not convenient, that is why there are many other applications that are used as console/terminal for Git. Visual Studio Code is one of the most popular ones.

Download and install the latest version of Visual Studio Code using the following link: 
> [Download Visual Studio Code](https://code.visualstudio.com/download)
<p> </p>

>**Note:** It is recommended to install Git first, followed by VSC. 
<p> </p>

# Set up

## Create and open project folder

Once Git and VSC are installed, create a folder on your PC or remote location where your project will reside and where your repository will be. After that open the folder that you have created via VSC by clicking the second icon in Explorer, as depicted in below image, or click *File/Open Folder...* in *Menu* tab of the program.

![Open Folder](/dz3/images/create_new_file_and_folder.jpg) 

>**Note:** Avoid using cyrilic letters in the path name to your folder
<p> </p>

## Initialize

>**Note:** Repository is not exactly the same thing as a folder with project files. Repository is a place where Git performs tracking of all changes in the project and controls them. While it is in the same place as the project folder, it is not created automatically when you create the folder. You need to initiate it using a command.

 - *git init* - a command that creates a Git repository

Once repository is created, you can start creating files in it and work on them.

At some point after creation of repository the program will ask you to introduce yourself.
Commands that and information that you will need to provide is as follows:
- *git config --global user.name < name >*
- *git config --global user.email < email address >*

<p> </p>

# Begin to work

## Create files and start working on project

To create a new file in repository just click on the first icon in Explorer or click *File/New File...* in *Menu* tab of the program.
<p> </p>

## Checking status or work

*git status* is one of most commonly used commands for working with Git. As name of the command suggests, it allows to see if there is anything that needs your attention.
Use this command before and after any changes you make to Git (add, commit, checkout, etc).
When type *git status* command pay attention to the following information that might be displayed in Terminal:

|Status of work| Desciption|
|----------|-----------|
|*Untracked, new file, modified*| - statuses of files that are due for commit
|*Changes not staged for commit*| - status of changes that are not ready yet for commit
|*Changes to be commited*| - status of changes that are ready for commit, have been staged
<p> </p>

The list of most common commands for checking the status of work, the history of commits, etc. are as follows:

|Command| Desciption|
|-------------|-----------|
|*git status*| - shows which branch you are on and whether there are any changes to project that are due for saving/commit
|*git log*| - shows the list of commits created (if any) previously
|*git log* --graph| - same function as above but with graphical representation of branches
|*git reflog*| - shows the list of all changes and movements in repository
|*git diff ##*| - checking the differences between the last two commits
|git diff < commit "a" hash > < commit "b" hash >| - checking the differences between selected two commits

>**Note:** If a list of information to display in Terminal after entering the command **git log** is extensive, Terminal might show just sigle cursor or the word **END** on the bottom most line. Just press letter **q** on the keyboard to exit to normal view. 
>>Beware of keyboard language layout. If it is not **English**, pressing **q** won't work.

![cursor](/images/cursor.jpg) - cursor 

![END](/images/end.jpg) - end
<p> </p>

## Save changes to project

The general rule for saving changes to your project to Git repository are as follows:
1. After you have made some changes to the files in your project and you are happy with what you have done, save the files same way as how you would usually do. I.e. press hotkey *Ctrl+s* on your keyboard or go to *File/Save*.
   >Note: if you don't save your files, the changes will not be saved into next commit. If you don't rememeber whether you saved files, look through all opened tabs - any unsaved file tabs will have white dot on the right, like this:

   ![white dot](/images/white_dot.jpg)

2. Stage files for the next commit. I.e. add them to the queque for saving into Git repository. To do that you need to use Add commands. There are several versions of such commands. They are listed below. Failng to do this step also will not save the changes to the next commit.

   |Command| Desciption|
   |----------|-----------|
   |*git add < file name >*| - Add a file which you want to stage, so that all changes made to this file are ready to be written into next commit. To speed up typing this command, after you typed a few letters of the file name, press Tab and Git will autocomplete the file name. Check if Git suggestion was correct, otherwise correct as you need manually.
   |*git add .*| - Add all files in the branch to stage. Do this if you do not have any exclusions, i.e. want to stage all files in the branch.

   Add and Commit commands can be combined into one command for some occasions. This will be explained futher down below in this help file.

3. Perform commit, i.e. save changes which you want to save into Git repository. This can be done with the following commands:

   |Command| Desciption|
   |----------|-----------|
   |*git commit -m < message >*| - Commit the staged files into Git repository. Type your message to distinguish this commit from others, so that you will know what was saved in it, if you will decide to go back to this commit in future.
   |*git commit -am < message >*| - This command combines Add and Commit commands into one. 
   |*git commit -m < message > < file >*| - This command will add and commit only specified file
   >*Note:* While the second and the third types of commit command save you time in most of occasions, note that they will not work if you have created or copied into the repository new files. In such case, you have to do Add and Commit in separate commands.

### __Why saving in three steps? Why do we need to *Add* for staging?__

The principle of **good** commmits is that they should not be too complex, but should be logically complete, i.e. to contain a work done on one aspect of a project, they should be clear to other team members of the project; it should be possible to move them around and remove. This principle of doing commits is call **atomic**.

Throughout the project it often happens that when a work on one aspect of the project is not complete yet, a need to perform a work on the other part of the project arises. And when all completed, if we commit all changes made to those two (or more) parts of the project into one commit we break the atomic rule. That's why we need the ability to choose which changed files we include into staging (*add*) for the next commit and which to keep unstaged for now in order to include them later on for future commits.
<p> </p>

### __Advanced *add* function for single file__

It often happens that in one file there may be some changes made for one taks of the project and also changes for the other task. If we have completed the first task and ready to commit it, but not finshed the second task and do not want to commit anything related to it, we can even choose which changes in that file we can to *add* to commit and which to leave off for now. Use this command for such cases:
   |Command| Desciption|
   |----------|-----------|
   |*git add -p < file >*| - Add only changes you want in the specified file. Once you enter this command you will be prompted what to do with certain hunk of the file. It will ask you "Stage this hunk [y, n, q, a, d, j, J, /, e, ?]. Type "?" if you are unsure.

<p> </p>

## Move commits around
There might be occastions when you will want to move to one of your previous commits and from there to come back to the latest commit. To do that you need to type the following command:

   |Command| Desciption|
   |----------|-----------|
   |*git checkout "< commit hash >"*| - Move to another commit. Specifying the first 4-6 symbols of commit is generally sufficient, no need to type fill number
   |*git checkout master*| - Go back to the most recent commit

>>>**THIS SECTION IS EXTENSIVE AND NOT COMPLETE YET. BESIDES *checkout*, IT CONTAINS SEVERAL POWERFULL COMMANDS, SUCH AS *rebase*, *cherry-pick* AND OTHERS. THE SECTION TO BE UPDATED IN FUTURE**
<p> </p>

## Undo last action

Example. If you executed *git add .* command and then realized that in the directory there were some new files which shouldn't have been staged for commmit, then you can use the following command:
   |Command| Desciption|
   |----------|-----------|
   |*git reset HEAD < file >*| - Removes a file, that have just been added to stage, from the staging
>**Note:** *reset* command is quite powerfull command. The details of *reset* command will follow in this quick guide in future updates.
<p> </p>

## Branches - create, delete, merge, move between
Branch is a feature which allows you to work on different areas of project independently. For instance, you might want to continue main work on the project while at the same time develop a feature of the project which, if succeeds, will be merged with main project in future.

![Branches](/images/branches.jpg)

Here are the commmands that can be used for branches:
|Command| Desciption|
|----------|-----------|
|*git branch*| - Displays the list of currently existing branches. And also highlights the branch in which you currently reside with green color and a star symbol
|*git branch < branch name >*| - Create new branch with < branch name >
|*git branch -d < branch name >*| - Delete an existing branch. Use small -d perferably. This way deleting will be performed only if all work in the branch is already merged with another branch
|*git checkout < branch or commit hash >*| - Move to the specified branch
|*git checkout -b < branch name >*| - Create new branch and move to it, in one command


## Merge branches
|Command| Desciption|
|----------|-----------|
|*git merge < branch name >*| - Merge a branch in which you currently reside with a branch you specify. I.e. merge to be done from a branch *into* which merge will be done. For instance, if you want merged information to be in branch "a", then make sure you are in this branch and then type "git merge branch b"
>**Note:** After branch "a" is merged with data from branch "b", branch "a" contains data of "a" and "b" (unless manually edited during conflict resolution), but branch "b" does not disappear. It still exists after merging in the same state as it was before merging. If branch "b" is not needed after merge, it needs to be deleted manually using command "git branch -d < branch name >*.

### Merge conflicts
If information was modified in the same files in both branches, Git will try to resolve the conflict by itself. However, it might fail to do that automatically, in which case Git will suggest you to resolve the conflict manually, as in the picture below:
![Merge Conflict](/images/merge_conflict.jpg)

You can either accept the changes in your current branch or accept the changes in incoming branch or accepth both changes.

Once the conflict is resolved either perform command *git merge --continue* or command *git commit -am < message >*. 
<p> </p>

# Working with remote repositories

There are many services available which offer remote repository functions to your version control system. 

As Git is on the most popular systems for controlling the versions, GitHub by Microsoft is one of the most popular services for remote storage/repository of version control systems.

There several ways to create a remote repository and sync your work to and from it. We will review here three most common ways to do that using GitHub:
 - copying your existing project on GitHub to your local repository
 - creating your own remote repository on GitHub and set up syncing of your local repository to and from it;
 - Using someones open-source project, modifying it and suggesting the owner to accept your changes to the project

## Steps for *clone* command to copy existing repository from remote location:

1. Find a repository which you want to copy to your local repository.

2. Copy the address of the repository as shown in picture below:

   ![Copy the address](/images/github_copy_https_address.jpg)

 **Note:** you don't need to register on Github in order to copy the repository. However, if you plan to sync your local version with GitHub in future you will need to have an account on [GitHub](https://github.com/)

3. Type *git clone* command in Terminal. This way Git will copy the remote repository to your local repository
<p> </p>

## Steps for *push* and *pull* commands to send and receive repositories from remote location:

1. Create an account on [GitHub](https://github.com/), if not done already

2. Create local repository

3. Authorize local repository on GitHub. Git will ask to login on GitHub. Perform the folloing commands for that:
 - *git remote add origin < url address>*
 - *git branch -M main*
 - *git push -u origin main*
 The meaning of these commands is explained in the table at the end of this section

4. For future, also use (*push*) command to send your local repository to remote (GitHub). You might need to authorize on remote repository, depending on whether you did that before or not.

5. You can make changes to your project from another computer or directly on GitHub.Someone else who has access to your remote repository can also make changes to it and ask for your permission to accept those changes

6. In order to sync your local repository with remote, download (*pull*) the most recent verion of repository from remote location to your local location
<p> </p>

## Steps of how to perform changes on open-source projects published on Github:

1. Do a *fork* of a repository of a project that you are interested in. By doing this you create a copy of the project on our own account in Github.

2. Do *git clone* for the project to create a copy of it on our local repository.

3. Create new branch in our local repository and make changes for the project that we suggest in this branch.

4. Perform all changes only in this new branch. Do not touch main/master branch of the project. This is a convention when working on someones open-source project.

5. Once finished send changed project (*push*) to our Github account.

6. On Github a button *Compare & Pull Request* will appear suggesting to send our changes to the Author of the project. The Author will review and decide if he wants to accept the changes, then to merge to his project if he accepts.

|Command| Desciption|
|----------|-----------|
|*git clone < url address >*| - copies remote repository to your local location. **Note**, this command not only loads repository to your local location, but also tries to merge remote repository with yours.
|*git pull*| - loads all from current remote repository to local repository and merge changes
|*git push*| - send your local version of repository to remote repository. **Note**, it requires initial authorization in remote repository
|*git remote add origin < url address>*| - adds new remote location to your local repository
|*git branch -M main*| - rename the main branch of the repository from *"master"* (default) to *"main"* (new convention)
|*git push -u origin main*| - send local repository version to the new location (*origin*)