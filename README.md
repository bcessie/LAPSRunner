# TL;TR
Execute other app from this app using the account it is running under

# Introduction
Frequently, on a daily basis we need to request for a LAPS password. What I try and do is only request this once and open what I would need during the day first thing in the morning. This includes Computer Management to look at queues, Task Manager to end tasks no longer needed and a couple instances of Visual Studio in administrative mode to get our solution running.

It is not always that easy to guess what you would need during the day and by running these couple of tasks, is already a time consuming (not required) ritual.

# What is Runner?
Runner is a Windows Forms application (.NET core 8.0) which will allow you to run what you need all at once using the correct account. When minimized the app will continue to run in the system tray until you close it, allowing you to open the app once as a specific user and execute other applications as the user throughout your day. This relieves you from requesting a new password for the same reason multiple times during the day.

This might be useful to others besides me..

I hope this eases your day!