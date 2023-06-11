# **Instructions about Git remote repositories** #

Remote repository is the virtual work place where you store your code.
We can push only two types of URL addresses:

- ***An HTTPS URL***
- ***An SSH URL***

# **Creating a remote repository** #

- ***git remote add*** -> uses for matching a remote URL with a name.
**git remote add origin "Remote_URL"**

## Cloning with HTTPS URLs ##

This type of cloning is available on all repositories, regardless of visibility. When using **git clone, git push or git pull** to a remote repository using HTTPS URLs on the command line, Git will ask for your GitHub username and password.

## Cloning with SSH URLs ##

SSH URLs provide access to a Git repository via SSH, a secure protocol. To use these URLs, you must generate an SSH key on your computer and add the public key to your account on GitHub.
When using te command like **git clone, git push or git pull** to a remote repository using SSH URLs, you'll be prompted for a password and must provide your SSH key passphrase.

**Commands we often use with remote repositories:**

- ***git remote*** -> command lets you create, view, and delete connections to other repositories. This command is really just an easier way to pass URLs to these "sharing" commands.
  
- ***git fetch*** -> The remote name can be passed as an argument to other Git commands to communicate with the remote repo. So then this command can be used to read from a remote repository.
  
- ***git clone*** -> is used for creating a copy or clone of a remote repository
  
- ***git pull*** ->  The remote name can be passed as an argument to other Git commands to communicate with the remote repo. So then this command can be used to read from a remote repository.
  
- ***git push*** ->command is used to write to a remote repository.

# **Instructions about Git** #

- ***git remote add*** -> add a git URL as an alias
- ***git fetch*** -> fetch down all the branches from that Git remote
- ***git merge*** -> merge a remote branch into your current branch to bring it up to date.