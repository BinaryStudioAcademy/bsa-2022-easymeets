using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EasyMeets.Core.WebAPI.Converters;

public class TimeOnlyConverter: JsonConverter<TimeOnly>
{
    public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
    {
        var valueJObject = new JObject(new JProperty("hour", value.Hour), new JProperty("minute", value.Minute));
        valueJObject.WriteTo(writer);
    }

    public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var jObject = JObject.Load(reader);
        var hours = (int?)jObject["hour"];
        if (hours is null)
        {
            throw new JsonSerializationException("Converter cannot find hour property.");
        }
        var minutes = (int?)jObject["minute"];
        if (minutes is null)
        {
            throw new JsonSerializationException("Converter cannot find minute property.");
        }
        return new TimeOnly(hours.Value, minutes.Value);
    }
}