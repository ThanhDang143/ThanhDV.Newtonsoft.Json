using System.Collections.Generic;

namespace Newtonsoft.Json
{
    public static class JsonUtilities
    {
        public static readonly IList<JsonConverter> UnityConverter = new JsonConverter[]
        {
            new Vector2Converter(),
            new Vector3Converter(),
            new Vector4Converter(),
            new QuaternionConverter(),
            new ColorConverter(),
            new Matrix4x4Converter()
        };

        public static readonly JsonSerializerSettings UnityJsonSettings = new()
        {
            Converters = new List<JsonConverter>(UnityConverter),
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            TypeNameHandling = TypeNameHandling.All
        };
    }
}
