0x03. Unity - UI

0. Scoreboard mandatory
We’ll be building off the last project to add UI elements (see example).

1. What does "new high score" mean? Is that bad? Did I break it? mandatory
Edit the PlayerController.cs script. Create a new public Text scoreText variable. In the Inspector, set the value of the scoreText field to your ScoreText GameObject.

2. HP mandatory
Inside the existing Canvas GameObject, create a new UI Image GameObject and name it HealthBG. Anchor it to the top left of the game window using Anchor Presets.

3. Health inspection mandatory
Edit the PlayerController.cs script. Create a new public Text healthText variable. In the Inspector, set the value of the healthText field to your HealthText GameObject.

4. Win, lose, or draw mandatory
Inside the existing Canvas GameObject, create a new UI Image GameObject and name it WinLoseBG. Anchor it to the center of the game window using Anchor Presets.

5. Chicken dinner mandatory
Edit the PlayerController.cs script so that when the Player touches the Goal

6. Game over, man, game over mandatory
Edit the PlayerController.cs script so that when the Player‘s health reaches 0

7. Wait a second... mandatory
The transition from the Game Over! text and the scene reloading is very sudden and abrupt. Let’s use a coroutine and WaitForSeconds() to create a delay where once the Player‘s health is 0 and the Game Over! text is displayed, the scene waits 3 seconds to reload.

8. What's on the menu mandatory
Create a new scene called Menu in the Project window. Add a new UI Panel GameObject called MenuBG

9. Let's play mandatory
Create a new C# script MainMenu.cs. Create a new method public void PlayMaze()

10. We're not retreating, we're advancing! Toward future victory! mandatory
Inside the MainMenu.cs script, create a new method public void QuitMaze().

11. A narrow variety of options mandatory
Inside the existing Canvas GameObject, create an empty GameObject called OptionsMenu. Anchor it to the center of the game window with Anchor Presets.

12. Accessibility mandatory
Having red traps and a green goal isn’t very accessible design for certain types of colorblindness. Ideally in game design, it would be better to avoid color coding important mechanics or objects entirely. For the sake of this UI project, we’ll add a Colorblind Mode option for our maze.