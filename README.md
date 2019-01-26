# OwO

<h2>Degeneracy and productivity</h2>
I call this app "OwO" because it adds degenerative suffixes such as that to "appropriate" places in strings.
I have created it to keep learning .NET and C# programming with Windows Forms. Using it to practice with simple functions, libraries, Windows Forms and communication between them.

<h2>Way more options than it has any right to have</h2>
You can add your own trigger words or emojis through the app itself or through the supplied .txt files.

<h2>Tips</h2>
<h3>Change the triggers and emojis</h3>
In case you want a different method of populating the lists navigate to *Form1.cs* and find the following code snippets:

in the constructor, delete the functions ```fileToKawaii(); and fileToSearch();``` and substitute them with</b>
```search.Add("Your_trigger")``` and ```kawaii.Add("Your_emoji");``` do that for every trigger and emoji you want to add.
Then scroll to the ```addTrigger(string str)``` and ```addKawaii(string str)``` functions and in them delete everything except the
```this.search.Add(str);``` and ```this.kawaii.Add(str);```

<b>Keep in mind that using this method, the changes you make in the app will not persist</b>

<h3>Editing triggers and emojis outside of the app</h3>
In case you don't want to open the app to change the triggers and emojis, you can simply find the search.txt and kawaii.txt files and change everything there.
I don't know why you would since the app doesn't use 50MB of RAM but okay.

<hr>
<h2>This project is not to be taken seriously, it is a mock app and was created as an exercise</h2>
</hr>
