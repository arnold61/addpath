Append a new directory to the windows path variable from the commandline.

VS2019 with framework .нет 4.7.2 used to compile. written in c#.

Sometimes during setup it is necessary to add a new path to the system path. With AddPath you can do this from commandline without any GUI. This is usefull in install.cmd files f.e.

usage: addpath D:\My\new\path

latest after reboot this path is set.

run as admin can be helpfull sometimes, duno as i am everytime admin.

example:
I have some usefull programms and scripts stored in a \_my\winpath directory on a stick. Now I can on any clientmachine copy the directory to the system and use addpath to set the path without walking through the gui. After the next reboot my tools are useable ...

have fun :)
