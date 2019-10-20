# Tetris 3D Game
3D Tetris game made in Unity

This game was made in Unity 2018.2.11f1
Please try to open the project using the same version or there might be some missing prefabs in the heirarchy that needs to be reimported.

**GAME CONTROLS:**
- S - Move downwards faster
- A - Move one block to the LEFT
- D - Move one block to the RIGHR
- L - Rotate 90 degrees to the Left
- R - Rotate 90 degrees to the Right


**GAME LOGIC:**

1. Define the play area (restricted boundaries) for cubes being spawned.
2. Spawn one block/shape at a time
3. Keep the shape moving downwards by one block as the time increments.
4. Apply left - right movement and rotation to the shape on key input.
5. Constantly check if the shape is within the play area and not intersecting with other shapes:
    a) If shape touches base, then set the postiion of the shape and spawn new
    b) If the shape touches other setted shape, then set the position and spawn new
    c) If the shape touches left/right boundaries of playarea then Debug.Log("No movement/rotation possible").
6. Constantly check the number of occupied blocks in each row and delete/destroy the entire row and send the number of destroyed rows to the UI
7. Increment level (speed of shapes movement) and Points based on the number of lines destroyed.
8. If the spawned cube touches the setted cube at the end of the play area, then application.exit();


**Executible Files for Game available in Builds Folder!**

1. Tetris-3D.exe    (Windows Version)
2. Tetris-3d-9.apk  (Android Version)
