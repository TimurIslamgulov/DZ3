# Basic instructions for Git 

## Start steps:

1. Install programm from Git site - **(https://git-scm.com/)**

2. Check how it works with command: *git --version*  
(**if all going right - you will see actual version of your git**)

3. Creating a repository - choose folder of your project by: **File - Open Folder**

4. Initializing your folder as a repository with command: *git init*

5. Create your own profile in Git system with next commands:
    * *git config --global user.name "Your name"*
    * *git config --global user.email "Your email"*

Well done! Your first Git repository is create!

## Basic commands:

- *git help* - help for all commands;

- *git add .* - add all files in this repository to future commit;

- *git add --all* - same comand as previous;

- *git add "File name"* - add to future commit only specific file;

- *git commit -m "Our comment"* - record changes to the repository with your comment;

- *git commit -**a**m "Our comment"* - allows you to combine "git add" with previous command - it allows you to avoid unnecessary actions;

- *git status* - The git status command displays the state of the working directory and the staging area. It lets you see which changes have been staged, which haven't, and which files aren't being tracked by Git. More about ignoring tracking - in .gitignore.;

- *git log* - shows to you information about save checkpoints;

- *git log __--graph__* - shows to you current branch ways;

- *git log __--all__* - shows you checkpoints (commits) in all your branches;

- *git log __--oneline__* - shows information in more compact view;

- *git reflog* - a similar command in a more compact form and including checkpoint load log;

- *git checkout "savepoint code"* - loading a specific savepoint - by full or short code (4 digits);

- *git checkout master* - loading your master savepoint;

- *git diff* - show changes between current work and last commit;

## Working with branches

- *git branch* - information menu about all current branches, as well as the basis of commands for working with them like:  
    1. *git branch __new_branch_name__* - creating a new branch with specified name;
    2. *git branch __-d__ new_branch_name* - removal a branch with specified name;

- *git merge new_branch_name* - including all changes from specified branch to current - This can lead to two kinds of developments:  
    1. Standard inclusion of all changes in the current branch from the one you selected in the command;
    2. Creation of a conflict that requires your direct participation in decision making;

## GitHub

GitHub is a web-based interface that uses Git, the open source version control software that lets multiple people make separate changes to web pages at the same time. 

To interract with this interface you can use some specified commands like:

1. *git remote* - Showing list of your remote connections to other repositories. Because this command supports the use of subcommands, it is also an interface for interacting with remote repositories:   
    * *git remote **add 'name' 'url'*** - Create a new connection to a remote repository. After adding the remote repository, the name 'name' can be used as a convenient shortcut for the 'url' address in other Git commands;
    * *git remote git remote **rm 'name'*** - Removing connection to a spicified remote repository with name 'name';
    * *git remote **rename 'old-name' 'new-name'*** - Rename the remote connection from 'old-name' to 'new-name';
    * *git remote **-v*** - Similar to the standard command, but also showing URL-address of all connections;
2. *git clone 'url'* - Copy remote repository on URL-address 'url' to your current local working folder. You can also use 'name' instead 'url' if you already establish connect with command above;
3. *git fetch 'name'* - this command connecting to your specified project - 'name' and  taking all data you don't have yet. After it, you should have links to all branches from this remote project, which you can view or merge at any time;
4. *git pull 'name'* - similar as command above but after you taking data from remote connection you automatically trying to merge this data with yours;
5. *git push 'name' 'branch name'* - Trying to push your branch 'branch name' to a remote repository named 'name'.  
    **It's Important!**   
    This command only works if you cloned from a server where you have write permissions, and if no one else has run the push command since then. If you and someone else clone at the same time, then they push, and then you try to push after them, your push will definitely be rejected. You will have to first fetch the changes and merge them with yours before you are allowed to push.

## Tips and Hints

- **.gitignore** - a way to exclude items you don't care about from the Git tracking system. Details in the picture:  
![.gitignore work example](Images\Gitignore_example.png)

- **Pull-request** - is a request to integrate changes from one branch into another. Moreover, a branch can have only one commit by one developer, or there can be several commits by different authors. In most cases, a pull request is used to integrate new functionality or to fix a bug in the main branch of a project.  
    If we will try to create our pull-request it will be include some steps:  
    1. **Fork** - creating a project branch in its own namespace:   
![fork example](Images\Fork_instruction.png)
    2. **Making changes to the project** - use the information above to interact and make changes to this project on your own GitHub space;
    3. **Creating a Pull-Request** - send your changes in specific 'branch name' branch to original author for making your own contribution in this project or performing any other tasks!

### This guide may be updated in the future.

