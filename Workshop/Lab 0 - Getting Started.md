Lab 0 - Getting Started


## <b>**Setting up your Cloud9 environment**</b>
1. Use a browser to go to  </br> https://286144240398.signin.aws.amazon.com/console
2. You should have received your `username` and `password` by the instructor
3. Enter your `username` in **IAM user name**  and `password` in **Password** field. 
4. You will see an AWS management console, In the service search for Cloud9, click on the cloud9 services
5. Click on Shared With me

     ![](static/lab0-1.png)

6. You will see a cloud9 environment, click on Open under Cloud9 IDE column.

7. Click on the Open IDE Button, It should open your IDE. Similar to below.





## Create your Git branch
1. Clone the repository if not done already. Run the following commands on the terminal window of your cloud9.

   ![](static/lab0-4.png)

``` 
git clone https://github.com/conceptsandbeyond/ATM-Project.git

cd ATM-Project/
```

2. Create a new feature branch based on the base branch. <br>Change Student<team number> to match with your login username (Team number). <br>Run following commands in your terminal window.

```
git checkout base

git checkout -b feature/Student<team number> base

```