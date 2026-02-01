namespace MyLittleRPG;

public class JsonSettings
{
    public JsonNode settings;
    private string file;

    public JsonNode this[string field] { get => this.settings[field]; set => settings[field] = value; }

    public JsonSettings()
    {
        this.file = File.ReadAllText("settings.json");
        this.settings = JsonNode.Parse(this.file);
    }
}