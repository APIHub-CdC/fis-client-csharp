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
    public partial class Score :  IEquatable<Score>
    {

        [JsonConstructorAttribute]
        protected Score() { }

        public Score(int valor = default(int), string codigo = default(string))
        {
            this.Valor = valor;
            this.Codigo = codigo;
        }
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public int Valor { get; set; }
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
       
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Score {\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Score);
        }
        public bool Equals(Score input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Valor == input.Valor ||
                    (this.Valor != null &&
                    this.Valor.Equals(input.Valor))
                ) && 
                (
                    this.Codigo == input.Codigo ||
                    (this.Codigo != null &&
                    this.Codigo.Equals(input.Codigo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Valor != null)
                    hashCode = hashCode * 59 + this.Valor.GetHashCode();
                if (this.Codigo != null)
                    hashCode = hashCode * 59 + this.Codigo.GetHashCode();
                return hashCode;
            }
        }
    }
}
