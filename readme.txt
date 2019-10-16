Append a new directory to the windows path variable from the commandline.
framework .нет 4.x required.
written in c#, source open.

Sometimes during setup it is necessary to add a new path to the system path. With AddPath you can do this from commandline without any GUI. This is usefull in install.cmd files f.e.

usage: addpath D:\My\new\path

latest after reboot this path is set.

run as admin can be helpfull sometimes, duno as i am everytime admin.

f.e. i have some usefull programms and rexx scripts stored in a \_my\winpath directory on a stick. Now a can on any clientmachine copy the directory to the systemdisc and use addpath to set the path without walking through the gui. After next reboot my tools are useable ...

have fun :)
