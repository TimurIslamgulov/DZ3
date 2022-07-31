# manual GIT 
![avatar](https://miro.medium.com/max/1200/1*hED79iPpQEcVg4R7BJs3SA.jpeg)

## basick commands

1. ```git init``` - initialization git
2. ```git status``` - check git
3. ```git add``` - add a change to tracking
4. ```git add .``` - tracking changes in all directives
5. ```commit``` *plus* ```-m" "``` or ```-am" "``` - save changes to the repository (-m"text" - add message or -am"text" add a change to tracking and save changes to the repository witt message **BUT** dont do the ```git add``` command)
6. ```git diff``` - the difference between a file in the repository and the current saved file (*for example, command git diff d2d5d78 f879c87 - show the difference between number 1 and number 10*)
7. ```git log``` - output of all file versions
8. ```git reflog``` - output of all, only commit
9. ```git checkout``` - switching to a different file version (*for example, command git checkout d2d5d78 f879c87 - switching to the version number 1)
10. ```git master``` - switching to the current file version

### commands for woking with GitHub

11. ```cd``` *plus* **/Users/alex/lesson1** - go to the local folder
12. ```ls``` - viewing a local folder
13. ```git clone``` *plus URL* - clone repository from github
14. ```git push``` - rpublishing a change to a remote repository
15. 
* ```git remote add origin``` *plus URL* - creating a record of a new connection to a remote repository 
* *__further__:* ```git branch - M main``` - set the main branch
* *__further__:* ```git push -u orgin main``` - establishes a connection between the branch in which we are located and the main branch on the remote server 
16. ``git pull``` - pull changes from a remote repository


### WARNING! 
1. always cmd+S

[detailed](https://git-scm.com/book/en/v2)

[RUS](https://git-scm.com/book/ru/v2)
