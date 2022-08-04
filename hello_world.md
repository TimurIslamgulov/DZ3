# Welcome to "Version Control" course!

*There is an instruction to use markdown language*

## Font Type
Frame your words between * to use italics type: *Italics*

Frame your words between ** to use bold type: **Bold**

Frame your words between 
~~ to use crossed out type: ~~Crossed out~~


## Lists
Use * at the start of the line to make unnumbered (bullet) list:
* Element 1
* Element 2
* Element 3

Use #. (1. for example) at the start of the line to make numbered list:
1. Element 1
2. Element 2
3. Element 3

Use tabulations (4 space) from previous line to make nested list:
1. Element 1
    * Subelement 1
        - Subsubelement 1 
2. Element 2
    + Subelement 2
        + Subsubelement 2            


## Headers
To use level 1 header type # at the start of the line:
# LVL1 Header

To use level 2 header type ## at the start of the line:
## LVL2 Header

*More "#" - lower lever of the header. Markdown supports 6 lvls of Headers*

## Images

If you want to add image to your markdown document type next:
**![text_if_image_unavailible](images/lomaem_git.jpg)**

---

# **Git. Typical commands**

*Some of typical commands we are use*

**git --version** - shows current version

**git status** - shows the state of the repository and staging area.

**git config --global user.name "Username"** - say hello to Git. This info will be in description to all your commits further. It's the first thing you must do at the start

**git config --global user.email email@email.com** - say hello to Git. This info will be in description to all your commits further. It's the first thing you must do at the start

**git init** - initiate repository at selected folder

**git add "filename"** - add your file to track (type without "")

**git add .** - add all saved changes

---

**git commit** - fix your changes. *Option **-m** allow you to set a comment to your commit. Every commit must have a commentary. Option **-a** inserts "git add" to your command if file already was added to track.*

*Example:* 

***git commit -am "Added new line to hello_world.md"** is the same command as the following two* 

***git add hello_world.md***

***git commit -m "Added new line to hello_world.md"***

---

**git log** - shows last commits with full info

**git reflog** - show all commits with short info

**git checkout "first_4_symbols_of_commit"** - detach head to selected commit (type without "")

**git checkout master** - move head to master (actual commit)

**git diff** - shows difference between last commit and actual status

**git diff "first_4_symbols_of_commit" "first_4_symbols_of_commit"** - shows difference between two selected commits (type without "")

## Branches
**git branch** - show list of all branches

**git branch branch_name** - make new branch

**git branch -d branch_name** - delete branch "branch_name"

**git checkout branch_name** - switch to branch "branch_name"

**git checkout -b branch name** - make new branch "branch_name" and then switch to it

**git merge branch_name** - merging *branch_name* changes to *current* branch

**git config --add merge.ff false** - disable fast-forward strategy for merge command

## Push & Pull, working with GitHub
**git remote** - manage set of tracked repositories

**git remote -v** - view tracked repositories with url-adress

**git remote add name url** - track new repository

**git remote rm name** - delete repository from track

**git remote rename old_name new_name** - rename tracked repository

**git push remote_name branch_name** - push your commits to the remote repository to the branch_name

**git pull** - pull out commits from the remote repository

**git clone url-adress** - make clone of remote repository

**git -set--upstream origin branch_name** - upstream branches are the branches on the remote repository that are tracked by a local remote branch in the local repository

## How to Pull Request

1. Make fork (copy) of remote repository to your GitHub
2. Clone this repository to your local station
3. Make new branch for your changes
4. Push them to your github repository from the 1 paragraph
5. Make Pull Request on the GitHub