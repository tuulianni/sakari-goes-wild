# How to contribute
- Create a fork of this repository to your own github account
![01_guide.png](./01_guide.png)
![02_guide.png](./02_guide.png)
- Clone the repo to your computer in a location of your choise
```bash
git clone git@github:<user>/sakari-goes-wild
```
- Add the upstream tuulianni/sakari-goes-wild
```bash
git remote add upstream https://github.com/tuulianni/sakari-goes-wild.git
```
- Fetch the upstream repo
```bash
git fetch upstream
```
- Keep your main branch up to date with the original repos main branch
```bash
git pull upstream main
git push origin main
```
- Create a new branch for whatever feature you work for
```bash
git branch new_feature
git checkout new_feature
# Or you can just do those two in one command
git checkout -b new_feature
```
- Code, add, commit and push as always
- Once you are ready to create a PR to the tuulianni/sakari-goes-wild repo
	- Make sure your new_feature branch has the latest updates from the upstream
```bash
# While the new_feature branch is checked out
git fetch upstream
git merge upstream/main
```
	- And create the pull request in github
![03_guide.png](./03_guide.png)
![04_guide.png](./04_guide.png)

