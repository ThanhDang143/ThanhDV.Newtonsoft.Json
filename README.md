# ThanhDV.Newtonsoft.Json

Unity package wrapping the Json.NET (Newtonsoft.Json) library as DLLs for easy use in Unity projects, with special care for **IL2CPP / AOT** platforms.

## Features
- Ships the official Newtonsoft.Json 13.0.1 DLL.
- Includes an AOT variant to reduce "Missing AOT compiled method" issues on iOS, Android IL2CPP, consoles, etc.
- Keeps the original namespace (`Newtonsoft.Json`).
- Simple integration through Unity Package Manager or local reference.

## Installation
### Unity Package Manager
```
https://github.com/ThanhDang143/ThanhDV.Utilities.git?path=/Assets/CustomPackages/Utilities
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
- Press the **+** button, choose "**Add package by name...**" → ``thanhdv.utilities``
- or
- Press the **Packages** button, choose "**My Registries**"

## How to use.
Example serialization / deserialization:
```csharp
using Newtonsoft.Json;

public class Demo
{
	class PlayerData
	{
		public string Name;
		public int Level;
	}

	public void Run()
	{
		var data = new PlayerData { Name = "Alice", Level = 5 };
		string json = JsonConvert.SerializeObject(data, Formatting.Indented);
		UnityEngine.Debug.Log(json);

		var clone = JsonConvert.DeserializeObject<PlayerData>(json);
		UnityEngine.Debug.Log($"Clone: {clone.Name} - {clone.Level}");
	}
}
```

---

## 🛠 IL2CPP & AOT Notes
- `Runtime/AOT` holds an adjusted DLL variant to mitigate stripping / missing generic instantiations.
- `link.xml` is included to preserve critical symbols during Unity's code stripping.
- If you still hit AOT issues (e.g. `ExecutionEngineException`, `MissingMethodException`):
  1. Confirm `link.xml` is included in the final build.
  2. Avoid heavy dynamic code patterns (`Type.GetType()` with non-literal names, late-bound reflection).
  3. Manually reference important generic types in a keeper script.

Example AOT keeper:
```csharp
static class AOTKeep
{
	static AOTKeep()
	{
		// Force generation of code paths for key generics
		_ = Newtonsoft.Json.JsonConvert.SerializeObject(new System.Collections.Generic.List<int>());
	}
}
```

---

## 📦 Folder Structure
```
Runtime/               Core DLL + XML docs
Runtime/AOT/           AOT-oriented DLL variant
Extension/             (Optional wrappers / helpers)
link.xml               Prevents stripping of required symbols
README.md
```

---

## 🔄 Upgrading Version
1. Download the new version from https://www.newtonsoft.com/json or NuGet.
2. Replace `Newtonsoft.Json.dll` and `Newtonsoft.Json.xml` under `Runtime/`.
3. Rebuild / re-create any AOT variant if needed (or keep if still valid).
4. Test an IL2CPP build.
5. Update the Version section below.

---

## 🧪 Quick Test
Create a script in a scene:
```csharp
using UnityEngine;
using Newtonsoft.Json;

public class Tester : MonoBehaviour
{
	void Start()
	{
		var obj = new { Msg = "Hello", Time = System.DateTime.UtcNow };
		Debug.Log(JsonConvert.SerializeObject(obj));
	}
}
```
Enter Play Mode and inspect the Console.

---

## 📝 Version History
- 13.0.1 (current): Mirrors Json.NET 13.0.1.

---

## 🤝 Contributing
Feel free to open Issues / Pull Requests (if public) to:
- Bump the Json.NET version.
- Add tests or examples.
- Improve AOT handling.

---

## ⚖️ License
- Newtonsoft.Json: MIT License (James Newton-King). See the original project for details.
- This wrapper package: Recommend MIT (add a LICENSE file if missing).

---

## ❓ Support
Not an official Unity or James Newton-King project. For core library bugs verify against the original Newtonsoft.Json repository first.

---

## 🔗 References
- Json.NET homepage: https://www.newtonsoft.com/json
- XML documentation included (IntelliSense friendly).

---

If you need additional sections (Git URL, CI badges, test samples), please request and they can be added.
