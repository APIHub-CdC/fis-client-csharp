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
    
    public enum CatalogoEstados
    {
        [EnumMember(Value = "AGS")]
        AGS = 1,
        [EnumMember(Value = "BC")]
        BC = 2,
        [EnumMember(Value = "BCS")]
        BCS = 3,
        [EnumMember(Value = "CAMP")]
        CAMP = 4,
        [EnumMember(Value = "COAH")]
        COAH = 5,
        [EnumMember(Value = "COL")]
        COL = 6,
        [EnumMember(Value = "CHIS")]
        CHIS = 7,
        [EnumMember(Value = "CHIH")]
        CHIH = 8,
        [EnumMember(Value = "DF")]
        DF = 9,
        [EnumMember(Value = "CDMX")]
        CDMX = 10,
        [EnumMember(Value = "DGO")]
        DGO = 11,
        [EnumMember(Value = "GTO")]
        GTO = 12,
        [EnumMember(Value = "GRO")]
        GRO = 13,
        [EnumMember(Value = "HGO")]
        HGO = 14,
        [EnumMember(Value = "JAL")]
        JAL = 15,
        [EnumMember(Value = "MEX")]
        MEX = 16,
        [EnumMember(Value = "MICH")]
        MICH = 17,
        [EnumMember(Value = "MOR")]
        MOR = 18,
        [EnumMember(Value = "NAY")]
        NAY = 19,
        [EnumMember(Value = "NL")]
        NL = 20,
        [EnumMember(Value = "OAX")]
        OAX = 21,
        [EnumMember(Value = "PUE")]
        PUE = 22,
        [EnumMember(Value = "QRO")]
        QRO = 23,
        [EnumMember(Value = "QROO")]
        QROO = 24,
        [EnumMember(Value = "SLP")]
        SLP = 25,
        [EnumMember(Value = "SIN")]
        SIN = 26,
        [EnumMember(Value = "SON")]
        SON = 27,
        [EnumMember(Value = "TAB")]
        TAB = 28,
        [EnumMember(Value = "TAMP")]
        TAMP = 29,
        [EnumMember(Value = "TLAX")]
        TLAX = 30,
        [EnumMember(Value = "VER")]
        VER = 31,
        [EnumMember(Value = "YUC")]
        YUC = 32,
        [EnumMember(Value = "ZAC")]
        ZAC = 33
    }
}
