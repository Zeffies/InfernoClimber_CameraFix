The Steam version of Inferno Climber has this weird bug with its camera that makes it so when you turn the camera while walking directly forward, the camera's momentum is inconsistent.

https://i.imgur.com/dst0hRq.mp4  Video here showing what I mean.

This mod removes the "camera tracking your character movement" that is in the Steam version of the game, which is conflicting with your own manual camera movement with the right analogue stick. 

Pretty simple mod, just one variable changed so that the game never decides to move the camera automatically behind you.

- Navigate to Releases on the right sidebar on Github, click the latest release, and download the DLL file and place it in your InfernoClimber\BepInEx\plugins folder. Follow tutorial below if you do not have this.

\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~

How to install mods for Inferno Climber (imgur links below each step to hopefully make it easy to follow):

1.) Download BepInEx from https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.2 .

!!! make sure to get the x86 version, you need this as Inferno Climber runs on it !!!

https://i.imgur.com/1ld1Snl.mp4

=======================================================

2.) extract all of the files from the BepInEx archive into the folder Inferno Climber's exe is in 

( something like C:\Program Files (x86)\Steam\steamapps\common\InfernoClimber ). 

Inferno Climber's exe is called ARPG.exe

https://i.imgur.com/tw4TwQi.mp4

=======================================================

3.) run Inferno Climber after extracting the BepInEx archive in the folder. This will generate some folders you need. 

!!! the game will crash, this is normal !!!

https://i.imgur.com/Y55yhQe.mp4

=======================================================

4.) to make the game not crash, we need to modify BepInEx's config file.

       -- navigate to \InfernoClimber\BepInEx\config
       -- open BepInEx.cfg with an editor ( Notepad works)
       -- Scroll down to [Preloader.Entrypoint]
       -- Change Type = Application to Type = MonoBehaviour
       -- Remember to save the notepad file!

https://i.imgur.com/8YSEceI.mp4

=======================================================

5.)  Optionally, you can enable BepInEx's logging console. It's in the [Logging.Console] section. I recommend it, personally.

https://i.imgur.com/iskhVZJ.png

=======================================================

6.) Put any mods you want in the \InfernoClimber\BepInEx\plugins folder.

https://i.imgur.com/T7Sujj2.mp4

=======================================================

7.) you're done! hooray!

\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~\~
