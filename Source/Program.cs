using MyLittleRPG.Game;

namespace MyLittleRPG;

public class Program
{
    public static JsonSettings settings;
    private static GameWindow gameWindow;

    static void Main(string[] args)
    {
        settings = new JsonSettings();
        gameWindow = new GameWindow();

        var set_window = (JsonObject)settings["window"];
        new Window().Start
        (
            (string)set_window["title"],
            ( (int)set_window["width"], (int)set_window["height"] ),
            gameWindow
        );
    }
}