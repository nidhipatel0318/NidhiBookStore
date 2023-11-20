2023-13-11
11:46
CREATED THE PROJECT
tested 
it works
created the git repo
 edited the startup.cs

 reviewing the stuff
 
 reviewd everythng
EDITTED THE BREAKING POITS
ON LINE 22 AND 27
tested 
its working

Ading the bootstrap from the bootswatch.com
SELECTED QUARTZ THEME

ADDED


replaced the site.js file and changed the name to bootstrap.css from bootsrap.min.css in _Layout.cshtml
replaced
commented

changedb the navbar
then removed the text dark in line 23

committted
now adding the additional properties to the footer class
testing

removed references to text dark from _LoginPartial.cshtml
now runnig the project

it works

adding the additionl links
added the links of css and js to _Layout.cshtml from the txt files provided
commited 


now adding the dropdown menu
added
commiting

now changing it to content management
changed 
testing
it worked

creating 3 new projects NidhisBooks.DataAccess, NidhisBooks.Models and NidhisBooks.Utility


created
now copying the Data Folder to .DataAccess folder
copied and deleted the original

Installing Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages
Installled
 Deleting the migrations
 intsaling the nuget package
 intalled

 Now deleteting the default classes
 Class1.cs

 deleed

 Finally Building the project
 Builed
  Moving the Models to .Models project
  Modifying thw Error,cshtml 

  Modified
  Adding the project refrence to .DataAccess and .Models PROJECT
  ADDED CHANGING THE	namespace
  changeddBuild the project
  builedd
  oops error in Error.cshtml file
 Modifying the stratup.cs AddContext

 running the application and reviewing the errorss
 done

 correctig the default to .Models.ViewModels.Error
 Ran the Application
 all working

 added the sd class in utitlity
ad the customer area to areas

changing the routes 

move the home controler cs to areas xustomer and dekleting the data and models folder.





202-11-14 
11:00
Doing part 2 now

builed the application to see if there are any errors
build succeed.
reviewing th app settings.json
chaniging the migrations

using nuget package manager console, added migration with meaningful name.


noted what happens when the defaukt project is selected

using .DatAccess project
Added the migration file
reviewed the file for sql file for syntax,statements etc.
11:23

updated the database
eviewed thge updated database.

checking for errors
it works

adding the new table to the DB by creating a Ctaaegory model and pushing it to th DB
added
adding the migration 
added
updated the migration

updted the database

11:46 am
Implementing the Repository
11:48
Added the folder Repository in .DataAccess and IRepossitry in it
11:57
modifie the IRepository class

added the repository class
modified the repository class
created the repos for ctegory class

categoryrepository.cs implemented the interfaces
it workssss

committed

adding the ISP_Call.cs to Irepository
now adding the SP_Call tO Repository
modified the SP_cALL CLASS


created the UnitOfWork interface in IRepsitory
modfied

now created UnitOfWork class in Repository
modified

2023-11-20 10:31
Solved the error and added the interface 
 now moving ahead
 closing all the currently opened tabs

 adding the categorycontroller.cs to areas->admin->controller
 created and modified 

 now adding the folder Category to Areas->Views
 added

 11:34 
 added the index.cshtml view
 
 11:37
 replaced the code given for index
 npr running the application

 found the error had index in wrong folder
 tested it is working

 added the fint awesome
 deleted and now doing the js

 2:21 created the js file and added the content given in the files

 2:24 
 adding thee @section to call the js
 ad

 2:26
 added
 now testing

 2:28 it works
 commiting

 2:35 added the IAction Result in CategoryController.cs
 now adding a view to CategoryController.cs

 2:38
 added the Upsert.cshtml to Category folder
 now adding th content from the files provided
 replaced
 2:40
 now creating the partial view 
 2:43 created the partial view in Views/Shared
 
 added the asp-action

 2:46
 now creating _EditAndBackToListButton 

 2:49 created and adding the asp action
 added th asp action