namespace MyLittleRPG;

public class Window
{
    public void Start(string windowTitle, (int width, int height) screenSize, IWindow iWindow) 
    {
        // creates a window
        Raylib.InitWindow(screenSize.width, screenSize.height, windowTitle);
        // initialize
        iWindow.Init();
        // set the target FPS
        Raylib.SetTargetFPS(60);

        // if in update
        while (!Raylib.WindowShouldClose() )
        {
            // call update
            iWindow.Update();
            // draw
            Raylib.BeginDrawing(); iWindow.Draw(); Raylib.EndDrawing();
        }

        // close window
        Raylib.CloseWindow();
    }
}
public interface IWindow
{
    /// <summary>
    /// Initialization method. Its called before Update gets called.<br/>
    /// Most used for initialize values, fields and etc.
    /// </summary>
    public void Init();
    /// <summary>
    /// Update method. Its called in every frame, but after Initialize.
    /// </summary>
    public void Update();
    /// <summary>
    /// Drawing method. Its called in every frame, inside of the Drawing context.<br/>
    /// Good for handle graphics in the screen.
    /// </summary>
    public void Draw();
}