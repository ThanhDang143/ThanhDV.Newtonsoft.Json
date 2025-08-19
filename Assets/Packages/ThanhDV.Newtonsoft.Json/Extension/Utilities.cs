using System.Collections.Generic;
using Newtonsoft.Json;

namespace ThanhDV.Newtonsoft.Json
{
    public static class Utilities
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
        };
    }
}
