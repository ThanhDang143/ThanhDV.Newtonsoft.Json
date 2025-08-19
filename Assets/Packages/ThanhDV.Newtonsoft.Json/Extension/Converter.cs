using System;
using Newtonsoft.Json;
using UnityEngine;

namespace ThanhDV.Newtonsoft.Json
{
    #region Vector2
    public class Vector2Converter : JsonConverter<Vector2>
    {
        public override void WriteJson(JsonWriter writer, Vector2 value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x"); writer.WriteValue(value.x);
            writer.WritePropertyName("y"); writer.WriteValue(value.y);
            writer.WriteEndObject();
        }

        public override Vector2 ReadJson(JsonReader reader, Type objectType, Vector2 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float x = 0, y = 0;
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    switch (n)
                    {
                        case "x": x = Convert.ToSingle(reader.Value); break;
                        case "y": y = Convert.ToSingle(reader.Value); break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            return new Vector2(x, y);
        }
    }
    #endregion

    #region Vector3
    public class Vector3Converter : JsonConverter<Vector3>
    {
        public override void WriteJson(JsonWriter writer, Vector3 value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x"); writer.WriteValue(value.x);
            writer.WritePropertyName("y"); writer.WriteValue(value.y);
            writer.WritePropertyName("z"); writer.WriteValue(value.z);
            writer.WriteEndObject();
        }
        public override Vector3 ReadJson(JsonReader reader, Type objectType, Vector3 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float x = 0, y = 0, z = 0;
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    switch (n)
                    {
                        case "x": x = Convert.ToSingle(reader.Value); break;
                        case "y": y = Convert.ToSingle(reader.Value); break;
                        case "z": z = Convert.ToSingle(reader.Value); break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            return new Vector3(x, y, z);
        }
    }
    #endregion

    #region Vector4
    public class Vector4Converter : JsonConverter<Vector4>
    {
        public override void WriteJson(JsonWriter writer, Vector4 value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x"); writer.WriteValue(value.x);
            writer.WritePropertyName("y"); writer.WriteValue(value.y);
            writer.WritePropertyName("z"); writer.WriteValue(value.z);
            writer.WritePropertyName("w"); writer.WriteValue(value.w);
            writer.WriteEndObject();
        }
        public override Vector4 ReadJson(JsonReader reader, Type objectType, Vector4 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float x = 0, y = 0, z = 0, w = 0;
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    switch (n)
                    {
                        case "x": x = Convert.ToSingle(reader.Value); break;
                        case "y": y = Convert.ToSingle(reader.Value); break;
                        case "z": z = Convert.ToSingle(reader.Value); break;
                        case "w": w = Convert.ToSingle(reader.Value); break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            return new Vector4(x, y, z, w);
        }
    }
    #endregion

    #region Quaternion
    public class QuaternionConverter : JsonConverter<Quaternion>
    {
        public override void WriteJson(JsonWriter writer, Quaternion value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x"); writer.WriteValue(value.x);
            writer.WritePropertyName("y"); writer.WriteValue(value.y);
            writer.WritePropertyName("z"); writer.WriteValue(value.z);
            writer.WritePropertyName("w"); writer.WriteValue(value.w);
            writer.WriteEndObject();
        }
        public override Quaternion ReadJson(JsonReader reader, Type objectType, Quaternion existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float x = 0, y = 0, z = 0, w = 0;
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    switch (n)
                    {
                        case "x": x = Convert.ToSingle(reader.Value); break;
                        case "y": y = Convert.ToSingle(reader.Value); break;
                        case "z": z = Convert.ToSingle(reader.Value); break;
                        case "w": w = Convert.ToSingle(reader.Value); break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            return new Quaternion(x, y, z, w);
        }
    }
    #endregion

    #region Color
    public class ColorConverter : JsonConverter<Color>
    {
        public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("r"); writer.WriteValue(value.r);
            writer.WritePropertyName("g"); writer.WriteValue(value.g);
            writer.WritePropertyName("b"); writer.WriteValue(value.b);
            writer.WritePropertyName("a"); writer.WriteValue(value.a);
            writer.WriteEndObject();
        }
        public override Color ReadJson(JsonReader reader, Type objectType, Color existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float r = 0, g = 0, b = 0, a = 0;
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    switch (n)
                    {
                        case "r": r = Convert.ToSingle(reader.Value); break;
                        case "g": g = Convert.ToSingle(reader.Value); break;
                        case "b": b = Convert.ToSingle(reader.Value); break;
                        case "a": a = Convert.ToSingle(reader.Value); break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            return new Color(r, g, b, a);
        }
    }
    #endregion

    #region Matrix4x4
    public class Matrix4x4Converter : JsonConverter<Matrix4x4>
    {
        public override void WriteJson(JsonWriter writer, Matrix4x4 value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("m00"); writer.WriteValue(value.m00);
            writer.WritePropertyName("m01"); writer.WriteValue(value.m01);
            writer.WritePropertyName("m02"); writer.WriteValue(value.m02);
            writer.WritePropertyName("m03"); writer.WriteValue(value.m03);

            writer.WritePropertyName("m10"); writer.WriteValue(value.m10);
            writer.WritePropertyName("m11"); writer.WriteValue(value.m11);
            writer.WritePropertyName("m12"); writer.WriteValue(value.m12);
            writer.WritePropertyName("m13"); writer.WriteValue(value.m13);

            writer.WritePropertyName("m20"); writer.WriteValue(value.m20);
            writer.WritePropertyName("m21"); writer.WriteValue(value.m21);
            writer.WritePropertyName("m22"); writer.WriteValue(value.m22);
            writer.WritePropertyName("m23"); writer.WriteValue(value.m23);

            writer.WritePropertyName("m30"); writer.WriteValue(value.m30);
            writer.WritePropertyName("m31"); writer.WriteValue(value.m31);
            writer.WritePropertyName("m32"); writer.WriteValue(value.m32);
            writer.WritePropertyName("m33"); writer.WriteValue(value.m33);
            writer.WriteEndObject();
        }
        public override Matrix4x4 ReadJson(JsonReader reader, Type objectType, Matrix4x4 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            float[] m = new float[16];
            if (reader.TokenType == JsonToken.Null) return default;
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var n = (string)reader.Value;
                    if (!reader.Read()) break;
                    float v = Convert.ToSingle(reader.Value);
                    switch (n)
                    {
                        case "m00": m[0] = v; break;
                        case "m01": m[1] = v; break;
                        case "m02": m[2] = v; break;
                        case "m03": m[3] = v; break;
                        case "m10": m[4] = v; break;
                        case "m11": m[5] = v; break;
                        case "m12": m[6] = v; break;
                        case "m13": m[7] = v; break;
                        case "m20": m[8] = v; break;
                        case "m21": m[9] = v; break;
                        case "m22": m[10] = v; break;
                        case "m23": m[11] = v; break;
                        case "m30": m[12] = v; break;
                        case "m31": m[13] = v; break;
                        case "m32": m[14] = v; break;
                        case "m33": m[15] = v; break;
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject) break;
            }
            Matrix4x4 mat = new Matrix4x4
            {
                m00 = m[0],
                m01 = m[1],
                m02 = m[2],
                m03 = m[3],
                m10 = m[4],
                m11 = m[5],
                m12 = m[6],
                m13 = m[7],
                m20 = m[8],
                m21 = m[9],
                m22 = m[10],
                m23 = m[11],
                m30 = m[12],
                m31 = m[13],
                m32 = m[14],
                m33 = m[15]
            };
            return mat;
        }
    }
    #endregion
}
