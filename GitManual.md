# GIT manual. Visual Studio Code. GitHub.com

# I. Before starting

1. **Open** *TERMINAL*

2. **Enter** commdand `git config --global user.name YOUR_NAME`

3. **Enter** commdand `git config --global user.email your_mail@email.com`

# II. Main operations with repositories

* `git status` - current info about changes within repository

## Creating local repositories

1. **Open** or **create** your target *folder* in *EXPLORER*
2. **Enter** commdand `git init` while inside target *folder* (creating repository)
3. **Create** target file (-s)

## Creating branches and versions

* `git branch BRANCH_NAME` - creat new branch in repository

1. Allways **save** all changes in file (-s) 
2. Tracking files within repository:
    * **Enter** commdand `git add FILE_NAME` to track one file
    * **Enter** commdand `git add .` to track all files in folder
3. **Enter** commdand `git commit -m YOUR_VERSION_COMMENT` (save new version within repository)
4. As long as working files are the same `git commit -am YOUR_VERSION_COMMENT` can be used several times after **steps 1-2**

# III. Working with versions and branches

## Info commands

* `git branch` - calls list of branches (`*` - current branch)
* `git log` - calls list of last versions (before current)
* `git log --graph` - call graphical list of last versions and branchs
* `git reflog` - calls list of all versions/branches/checkouts
* `git diff` - show difference between current uncommited version and master version (within saved files)
* `git diff COMMIT_NAME_1 COMMIT_NAME_2` - show difference between two specific versions

## Actions with versions and branches

* `git checkout NAME` - upload target version/branch from *log*/*reflog*/*branch* lists
* `git checkout master` - upload master version/branch
* `git checkout -b BRANCH_NAME` - creat new branch and upload it
* `git branch -d BRANCH_NAME` - delete some branches
* `git merge BRANCH_NAME` - insert branch version into current branch 
* `git merge BRANCH_NAME_1 BRANCH_NAME_2` - insert several branchs into current branch
* `git merge --abort` - abort last merge

## Other terms

* `Master` - last commited version within main branch (in GitHub.com named as "*main*")
* `Head` - current working version
* `clear` - command, that cleans terminals text
* `cd` - command, that changes working directory
* **Add** file `.gitignore` in main folder and make list of file to ignore via `git status` and `git add` (don't forget to commit ignore list into master branch)

# III. Remoted repositories with GitHub.com

## Main commands

* `git clone https:\\LINK_ADDRES` - dublicate remote repository to local machine
* `git pull` - download and merge all changes from linked remote repository 
* `git push` - upload and merge all changeas from local machine to linked remote repository (auth can be requested)

## Creating and working with remoted reposites
1. **Create** *Github.com* account
2. **Create** local repository
3. **Create** repository on *github.com* and **link** (instructions are within github.com) it with local repository
4. **Push** local repository to *github.com*
5. **Pull** repository from *github.com* to local if remoted version was changed

## Working with 3rd-party remoted repositories
1. **Fork** 3rd-party remote repository on *github.com* within your account 
2. **Clone** forked repository to local
3. **Change directory** in terminal (use command `cd`) to cloned
4. **Create** new branch and commit only in this branch
5. **Push** new commited version to your *github.com* 
6. **"Compare & Push"** version on *github.com* to send it to origin account with pull requset
