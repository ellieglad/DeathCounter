# DEATH COUNTER

A simple death counter for your games made with OBS in mind.


### How it works

When opening the program, it loads the number stored in the counter.txt file.
If there is no counter.txt file, the program will create it and assign a default number of 0.
This means you can either reset the counter manually or delete the file.

The program only accepts a numerical value. If the input is not accepted, it will flush the file and begin at 0.

You can either add or subtract 1 on the counter with the buttons, or change the file/counter manually.


### Work with OBS

1. Add a new text source to your scene.
2. Select "Read from file" and locate the counter.txt file.
3. Customise the font as you see fit.
4. Place the text source somewhere on the screen.
5. Done.

### Download compiled version.

https://github.com/PingCreations/DeathCounter/raw/master/DeathCounter.zip
