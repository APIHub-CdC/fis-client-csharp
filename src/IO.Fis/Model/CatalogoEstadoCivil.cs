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
    
    public enum CatalogoEstadoCivil
    {
        [EnumMember(Value = "D")]
        D = 1,
        [EnumMember(Value = "L")]
        L = 2,
        [EnumMember(Value = "C")]
        C = 3,
        [EnumMember(Value = "S")]
        S = 4,
        [EnumMember(Value = "V")]
        V = 5,
        [EnumMember(Value = "E")]
        E = 6
    }
}