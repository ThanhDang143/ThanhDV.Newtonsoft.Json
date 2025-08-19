# ThanhDV.Newtonsoft.Json

A Unity package wrapping the Json.NET (Newtonsoft.Json) library as DLLs for easy use in Unity projects, with some extensions by ThanhDV.

## Features
- Ships the official Newtonsoft.Json 13.0.1 DLL.
- Includes an AOT variant to reduce "Missing AOT compiled method" issues on iOS, Android IL2CPP, consoles, etc.
- Keeps the original namespace (`Newtonsoft.Json`).
- Simple integration through Unity Package Manager or local reference.

## Installation
### Unity Package Manager
```
https://github.com/ThanhDang143/ThanhDV.Newtonsoft.Json.git?path=/Assets/Packages/ThanhDV.Newtonsoft.Json
```

1. In Unity, open **Window** → **Package Manager**.
2. Press the **+** button, choose "**Add package from git URL...**"
3. Enter url above and press **Add**.

### Scoped Registry

1. In Unity, open **Project Settings** → **Package Manager** → **Add New Scoped Registry**
- ``Name`` ThanhDVs
- ``URL`` https://upm.thanhdv.icu
- ``Scope(s)`` thanhdv

2. In Unity, open **Window** → **Package Manager**.
- Press the **+** button, choose "**Add package by name...**" → ``thanhdv.newtonsoft.json``
- or
- Press the **Packages** button, choose "**My Registries**"

## How to use.
Example serialization / deserialization:
```csharp
using Newtonsoft.Json;
using UnityEngine;

public class Demo
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
```