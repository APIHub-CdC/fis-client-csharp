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
    
    public enum CatalogoSexo
    {
        [EnumMember(Value = "F")]
        F = 1,
        [EnumMember(Value = "M")]
        M = 2
    }
}
