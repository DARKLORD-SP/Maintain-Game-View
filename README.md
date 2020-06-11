# Maintain-Game-View
Maintaining the Game View For Different types of devices.

I Don't know If this is helpful for you guys, but i recently wanted to build an APK that runs both on Tablets and regular cell phone devices. Resizing UI was easy because its just tweaking some settings. But when it comes to show the same amount of gameplay content on different type of devices it was tricky, well at least for me. I known many of you guys have been in this place where in some devices u see more of the game view and in some of the devices u see less unless its the same resolution device which your game was made to run on. I searched a lot then i came across this post.

http://www.luispedrofonseca.com/unity-supporting-multiple-aspect-ratios/

Go and read it if you want to basically its something to do with the main camera. The post and the asset he was referring to was for 2D game. But the concept must me same for 3D also. There was nothing related to 3D anywhere.

I was just doing some random things with camera. And suddenly it all worked. I was able to maintain my game content area on multiple screen sizes, without any hesitations. Create a object of GameviewMaintainer class after importing the Provided .dll file into the project Then u just feed in an target resolution that u want to refer to and the Camera To Apply to when creating object, and the script will do the rest. Beware that its not perfect. i really hope that one of you guys can make it perfect and share it with me as well. Till now this is what i have done. Just attach the script to Main Camera give it a reference resolution EX: the resolution your game is made in. mostly its is 1920*1080 or 1080*1920. Just Keep the Orientation same for the final Game if its portrait than keep the whole game portrait or if landscape then keep it that way. do not let the orientation change in middle of the game.

Again if anyone wants to share an improved or proper version of the script then please DO SO!


  GameViewMaintainer gm = new GameViewMaintainer(myMainCamera, new Vector2(1080,1920));
  
Thats it! once the object is created it will maintain the Resolution.
