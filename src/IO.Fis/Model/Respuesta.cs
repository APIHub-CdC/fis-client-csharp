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
    [DataContract]
    public partial class Respuesta :  IEquatable<Respuesta>
    {
        public Respuesta(Score scoreNoHit = default(Score), string folioConsulta = default(string))
        {
            this.ScoreNoHit = scoreNoHit;
            this.FolioConsulta = folioConsulta;
        }

        [DataMember(Name="scoreNoHit", EmitDefaultValue=false)]
        public Score ScoreNoHit { get; set; }
        [DataMember(Name="folioConsulta", EmitDefaultValue=false)]
        public string FolioConsulta { get; set; }
       
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Respuesta {\n");
            sb.Append("  ScoreNoHit: ").Append(ScoreNoHit).Append("\n");
            sb.Append("  FolioConsulta: ").Append(FolioConsulta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Respuesta);
        }
        public bool Equals(Respuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ScoreNoHit == input.ScoreNoHit ||
                    (this.ScoreNoHit != null &&
                    this.ScoreNoHit.Equals(input.ScoreNoHit))
                ) &&
                (
                    this.FolioConsulta == input.FolioConsulta ||
                    (this.FolioConsulta != null &&
                    this.FolioConsulta.Equals(input.FolioConsulta))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ScoreNoHit != null)
                    hashCode = hashCode * 59 + this.ScoreNoHit.GetHashCode();
                if (this.FolioConsulta != null)
                    hashCode = hashCode * 59 + this.FolioConsulta.GetHashCode();
                return hashCode;
            }
        }
    }
}
