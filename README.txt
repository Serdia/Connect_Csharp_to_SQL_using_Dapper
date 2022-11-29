https://www.youtube.com/watch?v=Et2khGnrIqc&t=800s

1) need to create a model that I can put data into. That model is simply a class. (so add--> class, name: Person)
  each class instance will be one person.
2) setup a connection string helper that we'll put in app.config file so we can read how to talk to a database. 
  so for that, add a new class "Helper.cs"
3) need to add reference (i think in .NET6 you do not need to do that, basically its a statement using System.Configuration; )
4) need to add a connection string to App.config
   "https://www.connectionstrings.com/sql-server/" is a good source to see how to make connection strings. 
5) add listBox in the WinForm and all necessary objects (buttons, listbox etc)
6) create class DataAccess