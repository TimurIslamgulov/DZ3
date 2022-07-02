
# INTRODUCTION

This folder will contain the explanation of the usage of some GIT commands.

***The goals of this presentation are:***

* to reapeat the lecture material
* to have a practice with GIT and its commands
* to have some practice with MarkDown
* to keep Timur busy 
* something else probably, but nothing pops up in my head yet

<font size="1"> Remark: this project was written in english not because I am showing off, but because my macbook has danish keyboard and it is a little bit of suffering to use it in russian.</font>

# GIT INIT

The **_git init_** command is the first command that you will run on Git. The git init command is used to create a new blank repository. It is used to make an existing project as a Git project. Several Git commands run inside the repository, but init command can be run outside of the repository.

![Letsgo](start.jpg)

# GIT STATUS

The **_git status_** command is used to display the state of the repository and staging area. It allows us to see the tracked, untracked files and changes. This command will not show any commit records or information. Mostly, it is used to display the state between Git Add and Git commit command.

![200.gif](200.gif)
How do I exit git status?
1 Answer: q

# GIT DIFF

The **_git diff_** command shows the differences between the files in two commits or between your current repository and a previous commit. This command displays changes denotes by headers and metadata for the files that have changed.

![leviOsa](hermiona.webp)

# GIT LOG

**_Git log_** is a utility tool to review and read a history of everything that happens to a repository. Multiple options can be used with a git log to make history more specific. Generally, the git log is a record of commits. To exit the log, press "q".

![Log](log.gif)

New line for the conflict.

# GIT ADD

The **_git add_** command adds new or changed files in your working directory to the Git staging area. git add is an important command - without it, no git commit would ever do anything. Sometimes, git add can have a reputation for being an unnecessary step in development.

The new line to create a conflict.
![Earth](earth.gif)

# GIT COMMIT

The **_commit_** command is used to save your changes to the local repository. Note that you have to explicitly tell Git which changes you want to include in a commit before running the "git commit" command. This means that a file won't be automatically included in the next commit just because it was changed.

<font size ="1">


The command should be used as git commit -m "comment"</font>



![DoIt](office.webp)

# GIT CHECKOUT

In Git, the term checkout is used for **the act of switching between different versions of a target entity**. The git checkout command is used to switch between branches in a repository. Be careful with your staged files and commits when switching between branches.


Remember, all git pull does is run git fetch and then git merge (or git fetch and then git rebase ). It's the git checkout that is messing with the time-stamps on your work-tree files. Git doesn't really use or need the work-tree: that's for you.

## GIT CLONE

**_Git clone_** is a Git command line utility which is used to target an existing repository and create a clone, or copy of the target repository. In this page we'll discuss extended configuration options and common use cases of git clone . Some points we'll cover here are: Cloning a local or remote repository.


## GIT REMOTE

The **_git remote_** command lets you create, view, and delete connections to other repositories. Remote connections are more like bookmarks rather than direct links into other repositories. 

git remote add origin <url> adds the kink to the remote repository.
git remote -v shows which remote repositories you are connected to
git remote remove <repository name or origin> removed the link with the remote repository


## GIT BRANCH

The **_git branch_** command can be used to create a new branch. When you want to start a new feature, you create a new branch off main using git branch new_branch . Once created you can then use git checkout new_branch to switch to that branch.

git branch new_name creates a new branch
git branch shows the list of all existing branches
git branch -v shows the last commit for each branch
git branch -d new_name deletes the branch
git branch --move new_name new_corrected_name renames the existing branch saving all the info of the branch, but it requestst extra push to git hub of the new named branch and removing the old name branch.

## GIT PUSH

The **_Git push_** command is used to push the local repository content to a remote repository. After a local repository has been modified, a push is executed to share the modifications with remote team members. Pushing is the way commits are transferred from the local repository to the remote repository.


## GIT PULL

The **_git pull_** command is used to fetch and download content from a remote repository and immediately update the local repository to match that content. Merging remote upstream changes into your local repository is a common task in Git-based collaboration work flows.