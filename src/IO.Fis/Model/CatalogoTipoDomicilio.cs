using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ApihubDateConverter = IO.Fis.Client.ApihubDateConverter;

namespace IO.Fis.Model
{
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CatalogoTipoDomicilio
    {
        [EnumMember(Value = "N")]
        N = 1,
        [EnumMember(Value = "O")]
        O = 2,
        [EnumMember(Value = "C")]
        C = 3,
        [EnumMember(Value = "P")]
        P = 4,
        [EnumMember(Value = "E")]
        E = 5
    }
}
