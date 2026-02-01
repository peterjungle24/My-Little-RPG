namespace MyLittleRPG.Game;

public class GameWindow : IWindow
{
    public void Init()
    {
    }
    public void Update()
    {
    }
    public void Draw()
    {
        Raylib.ClearBackground(Color.Blue);
        Raylib.DrawText("hello!", 30, 30, 10, Color.White);
    }
}
