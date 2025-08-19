using Newtonsoft.Json;
using UnityEngine;

public class Tester : MonoBehaviour
{
    class PlayerData
    {
        public string Name;
        public int Level;
        public Vector3 Pos;
    }

    public void Run()
    {
        var data = new PlayerData { Name = "Alice", Level = 5, Pos = Vector3.zero };
        JsonSerializerSettings settings = JsonUtilities.UnityJsonSettings;

        string json = JsonConvert.SerializeObject(data, Formatting.Indented, settings);
        Debug.Log(json);

        var clone = JsonConvert.DeserializeObject<PlayerData>(json, settings);
        Debug.Log($"Clone: {clone.Name} - {clone.Level}");
    }
}
