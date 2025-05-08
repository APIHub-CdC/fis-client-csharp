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
       
    public enum CatalogoResidencia
    {
        
        NUMBER_1 = 1,
        NUMBER_2 = 2,     
        NUMBER_3 = 3,      
        NUMBER_4 = 4, 
        NUMBER_5 = 5
    }
}
