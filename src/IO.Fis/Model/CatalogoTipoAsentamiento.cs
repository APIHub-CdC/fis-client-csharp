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
    
    public enum CatalogoTipoAsentamiento
    {
        [EnumMember(Value = "0")]
        _0 = 1,
        [EnumMember(Value = "1")]
        _1 = 2,
        [EnumMember(Value = "2")]
        _2 = 3,
        [EnumMember(Value = "3")]
        _3 = 4,
        [EnumMember(Value = "4")]
        _4 = 5,
        [EnumMember(Value = "5")]
        _5 = 6,
        [EnumMember(Value = "6")]
        _6 = 7,
        [EnumMember(Value = "7")]
        _7 = 8,
        [EnumMember(Value = "8")]
        _8 = 9,
        [EnumMember(Value = "9")]
        _9 = 10,
        [EnumMember(Value = "10")]
        _10 = 11,
        [EnumMember(Value = "11")]
        _11 = 12,
        [EnumMember(Value = "12")]
        _12 = 13,
        [EnumMember(Value = "13")]
        _13 = 14,
        [EnumMember(Value = "14")]
        _14 = 15,
        [EnumMember(Value = "15")]
        _15 = 16,
        [EnumMember(Value = "16")]
        _16 = 17,
        [EnumMember(Value = "17")]
        _17 = 18,
        [EnumMember(Value = "18")]
        _18 = 19,
        [EnumMember(Value = "19")]
        _19 = 20,
        [EnumMember(Value = "20")]
        _20 = 21,
        [EnumMember(Value = "21")]
        _21 = 22,
        [EnumMember(Value = "22")]
        _22 = 23,
        [EnumMember(Value = "23")]
        _23 = 24,
        [EnumMember(Value = "24")]
        _24 = 25,
        [EnumMember(Value = "25")]
        _25 = 26,
        [EnumMember(Value = "26")]
        _26 = 27,
        [EnumMember(Value = "27")]
        _27 = 28,
        [EnumMember(Value = "28")]
        _28 = 29,
        [EnumMember(Value = "29")]
        _29 = 30,
        [EnumMember(Value = "30")]
        _30 = 31,
        [EnumMember(Value = "31")]
        _31 = 32,
        [EnumMember(Value = "32")]
        _32 = 33,
        [EnumMember(Value = "33")]
        _33 = 34,
        [EnumMember(Value = "34")]
        _34 = 35,
        [EnumMember(Value = "35")]
        _35 = 36,
        [EnumMember(Value = "36")]
        _36 = 37,
        [EnumMember(Value = "37")]
        _37 = 38,
        [EnumMember(Value = "38")]
        _38 = 39,
        [EnumMember(Value = "39")]
        _39 = 40,
        [EnumMember(Value = "40")]
        _40 = 41,
        [EnumMember(Value = "41")]
        _41 = 42,
        [EnumMember(Value = "42")]
        _42 = 43,
        [EnumMember(Value = "43")]
        _43 = 44,
        [EnumMember(Value = "44")]
        _44 = 45,
        [EnumMember(Value = "45")]
        _45 = 46,
        [EnumMember(Value = "46")]
        _46 = 47,
        [EnumMember(Value = "47")]
        _47 = 48,
        [EnumMember(Value = "48")]
        _48 = 49,
        [EnumMember(Value = "49")]
        _49 = 50,
        [EnumMember(Value = "50")]
        _50 = 51,
        [EnumMember(Value = "51")]
        _51 = 52,
        [EnumMember(Value = "52")]
        _52 = 53,
        [EnumMember(Value = "53")]
        _53 = 54,
        [EnumMember(Value = "54")]
        _54 = 55,
        [EnumMember(Value = "55")]
        _55 = 56
    }
}
