using Newtonsoft.Json.Converters;

namespace IO.Fis.Client
{
    public class ApihubDateConverter : IsoDateTimeConverter
    {
        public ApihubDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
