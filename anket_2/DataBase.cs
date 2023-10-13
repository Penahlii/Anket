#nullable disable

using Newtonsoft.Json;

namespace anket_2;

public class DataBase
{
    public List<User> users { get; set; }

    public void program_start()
    {
        if (File.Exists("users.json"))
        {
            string json = File.ReadAllText("users.json");
            if (!(string.IsNullOrWhiteSpace(json)))
                this.users = JsonConvert.DeserializeObject<List<User>>(json);
        }
        else
            this.users = new();
    }

    public void write()
    {
        string js = JsonConvert.SerializeObject(this.users, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("users.json", js);
    }

    public DataBase() { this.users = new(); }
}