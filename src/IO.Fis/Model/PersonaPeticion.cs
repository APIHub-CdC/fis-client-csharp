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
    public partial class PersonaPeticion :  IEquatable<PersonaPeticion>, IValidatableObject
    {
        
        [JsonConstructorAttribute]
        protected PersonaPeticion() { }

        public PersonaPeticion(string apellidoPaterno = default(string), string apellidoMaterno = default(string), string apellidoAdicional = default(string), string primerNombre = default(string), string segundoNombre = default(string), string fechaNacimiento = default(string), string rFC = default(string), string cURP = default(string), CatalogoNacionalidad? nacionalidad = default(CatalogoNacionalidad?), CatalogoResidencia? residencia = default(CatalogoResidencia?), CatalogoEstadoCivil? estadoCivil = default(CatalogoEstadoCivil?), CatalogoSexo? sexo = default(CatalogoSexo?), string claveElectorIFE = default(string), int? numeroDependientes = default(int?), string fechaDefuncion = default(string), DomicilioPeticion domicilio = default(DomicilioPeticion))
        {
            
            this.ApellidoPaterno = apellidoPaterno;
        
            this.ApellidoMaterno = apellidoMaterno;
        
            this.PrimerNombre = primerNombre;
        
            this.FechaNacimiento = fechaNacimiento;
        
            this.RFC = rFC;
        
            this.Nacionalidad = nacionalidad;
        
            this.Domicilio = domicilio;
            this.ApellidoAdicional = apellidoAdicional;
            this.SegundoNombre = segundoNombre;
            this.CURP = cURP;
            this.Nacionalidad = nacionalidad;
            this.Residencia = residencia;
            this.EstadoCivil = estadoCivil;
            this.Sexo = sexo;
            this.ClaveElectorIFE = claveElectorIFE;
            this.NumeroDependientes = numeroDependientes;
            this.FechaDefuncion = fechaDefuncion;
        }

        [DataMember(Name="apellidoPaterno", EmitDefaultValue=false)]
        public string ApellidoPaterno { get; set; }
        [DataMember(Name="apellidoMaterno", EmitDefaultValue=false)]
        public string ApellidoMaterno { get; set; }
        [DataMember(Name="apellidoAdicional", EmitDefaultValue=false)]
        public string ApellidoAdicional { get; set; }
        [DataMember(Name="primerNombre", EmitDefaultValue=false)]
        public string PrimerNombre { get; set; }
        [DataMember(Name="segundoNombre", EmitDefaultValue=false)]
        public string SegundoNombre { get; set; }
        [DataMember(Name="fechaNacimiento", EmitDefaultValue=false)]
        public string FechaNacimiento { get; set; }
        [DataMember(Name="RFC", EmitDefaultValue=false)]
        public string RFC { get; set; }
        [DataMember(Name="CURP", EmitDefaultValue=false)]
        public string CURP { get; set; }
        [DataMember(Name="nacionalidad", EmitDefaultValue=false)]
        public CatalogoNacionalidad? Nacionalidad { get; set; }
        [DataMember(Name="residencia", EmitDefaultValue=false)]
        public CatalogoResidencia? Residencia { get; set; }
        [DataMember(Name="estadoCivil", EmitDefaultValue=false)]
        public CatalogoEstadoCivil? EstadoCivil { get; set; }
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public CatalogoSexo? Sexo { get; set; }
        [DataMember(Name="claveElectorIFE", EmitDefaultValue=false)]
        public string ClaveElectorIFE { get; set; }
        [DataMember(Name="numeroDependientes", EmitDefaultValue=false)]
        public int? NumeroDependientes { get; set; }
        [DataMember(Name="fechaDefuncion", EmitDefaultValue=false)]
        public string FechaDefuncion { get; set; }
        [DataMember(Name="domicilio", EmitDefaultValue=false)]
        public DomicilioPeticion Domicilio { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonaPeticion {\n");
            sb.Append("  ApellidoPaterno: ").Append(ApellidoPaterno).Append("\n");
            sb.Append("  ApellidoMaterno: ").Append(ApellidoMaterno).Append("\n");
            sb.Append("  ApellidoAdicional: ").Append(ApellidoAdicional).Append("\n");
            sb.Append("  PrimerNombre: ").Append(PrimerNombre).Append("\n");
            sb.Append("  SegundoNombre: ").Append(SegundoNombre).Append("\n");
            sb.Append("  FechaNacimiento: ").Append(FechaNacimiento).Append("\n");
            sb.Append("  RFC: ").Append(RFC).Append("\n");
            sb.Append("  CURP: ").Append(CURP).Append("\n");
            sb.Append("  Nacionalidad: ").Append(Nacionalidad).Append("\n");
            sb.Append("  Residencia: ").Append(Residencia).Append("\n");
            sb.Append("  EstadoCivil: ").Append(EstadoCivil).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  ClaveElectorIFE: ").Append(ClaveElectorIFE).Append("\n");
            sb.Append("  NumeroDependientes: ").Append(NumeroDependientes).Append("\n");
            sb.Append("  FechaDefuncion: ").Append(FechaDefuncion).Append("\n");
            sb.Append("  Domicilio: ").Append(Domicilio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as PersonaPeticion);
        }
        public bool Equals(PersonaPeticion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ApellidoPaterno == input.ApellidoPaterno ||
                    (this.ApellidoPaterno != null &&
                    this.ApellidoPaterno.Equals(input.ApellidoPaterno))
                ) && 
                (
                    this.ApellidoMaterno == input.ApellidoMaterno ||
                    (this.ApellidoMaterno != null &&
                    this.ApellidoMaterno.Equals(input.ApellidoMaterno))
                ) && 
                (
                    this.ApellidoAdicional == input.ApellidoAdicional ||
                    (this.ApellidoAdicional != null &&
                    this.ApellidoAdicional.Equals(input.ApellidoAdicional))
                ) && 
                (
                    this.PrimerNombre == input.PrimerNombre ||
                    (this.PrimerNombre != null &&
                    this.PrimerNombre.Equals(input.PrimerNombre))
                ) && 
                (
                    this.SegundoNombre == input.SegundoNombre ||
                    (this.SegundoNombre != null &&
                    this.SegundoNombre.Equals(input.SegundoNombre))
                ) && 
                (
                    this.FechaNacimiento == input.FechaNacimiento ||
                    (this.FechaNacimiento != null &&
                    this.FechaNacimiento.Equals(input.FechaNacimiento))
                ) && 
                (
                    this.RFC == input.RFC ||
                    (this.RFC != null &&
                    this.RFC.Equals(input.RFC))
                ) && 
                (
                    this.CURP == input.CURP ||
                    (this.CURP != null &&
                    this.CURP.Equals(input.CURP))
                ) && 
                (
                    this.Nacionalidad == input.Nacionalidad ||
                    (this.Nacionalidad != null &&
                    this.Nacionalidad.Equals(input.Nacionalidad))
                ) && 
                (
                    this.Residencia == input.Residencia ||
                    (this.Residencia != null &&
                    this.Residencia.Equals(input.Residencia))
                ) && 
                (
                    this.EstadoCivil == input.EstadoCivil ||
                    (this.EstadoCivil != null &&
                    this.EstadoCivil.Equals(input.EstadoCivil))
                ) && 
                (
                    this.Sexo == input.Sexo ||
                    (this.Sexo != null &&
                    this.Sexo.Equals(input.Sexo))
                ) && 
                (
                    this.ClaveElectorIFE == input.ClaveElectorIFE ||
                    (this.ClaveElectorIFE != null &&
                    this.ClaveElectorIFE.Equals(input.ClaveElectorIFE))
                ) && 
                (
                    this.NumeroDependientes == input.NumeroDependientes ||
                    (this.NumeroDependientes != null &&
                    this.NumeroDependientes.Equals(input.NumeroDependientes))
                ) && 
                (
                    this.FechaDefuncion == input.FechaDefuncion ||
                    (this.FechaDefuncion != null &&
                    this.FechaDefuncion.Equals(input.FechaDefuncion))
                ) && 
                (
                    this.Domicilio == input.Domicilio ||
                    (this.Domicilio != null &&
                    this.Domicilio.Equals(input.Domicilio))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ApellidoPaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoPaterno.GetHashCode();
                if (this.ApellidoMaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoMaterno.GetHashCode();
                if (this.ApellidoAdicional != null)
                    hashCode = hashCode * 59 + this.ApellidoAdicional.GetHashCode();
                if (this.PrimerNombre != null)
                    hashCode = hashCode * 59 + this.PrimerNombre.GetHashCode();
                if (this.SegundoNombre != null)
                    hashCode = hashCode * 59 + this.SegundoNombre.GetHashCode();
                if (this.FechaNacimiento != null)
                    hashCode = hashCode * 59 + this.FechaNacimiento.GetHashCode();
                if (this.RFC != null)
                    hashCode = hashCode * 59 + this.RFC.GetHashCode();
                if (this.CURP != null)
                    hashCode = hashCode * 59 + this.CURP.GetHashCode();
                if (this.Nacionalidad != null)
                    hashCode = hashCode * 59 + this.Nacionalidad.GetHashCode();
                if (this.Residencia != null)
                    hashCode = hashCode * 59 + this.Residencia.GetHashCode();
                if (this.EstadoCivil != null)
                    hashCode = hashCode * 59 + this.EstadoCivil.GetHashCode();
                if (this.Sexo != null)
                    hashCode = hashCode * 59 + this.Sexo.GetHashCode();
                if (this.ClaveElectorIFE != null)
                    hashCode = hashCode * 59 + this.ClaveElectorIFE.GetHashCode();
                if (this.NumeroDependientes != null)
                    hashCode = hashCode * 59 + this.NumeroDependientes.GetHashCode();
                if (this.FechaDefuncion != null)
                    hashCode = hashCode * 59 + this.FechaDefuncion.GetHashCode();
                if (this.Domicilio != null)
                    hashCode = hashCode * 59 + this.Domicilio.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.ApellidoPaterno != null && this.ApellidoPaterno.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoPaterno, length must be less than 30.", new [] { "ApellidoPaterno" });
            }
            if(this.ApellidoMaterno != null && this.ApellidoMaterno.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoMaterno, length must be less than 30.", new [] { "ApellidoMaterno" });
            }
            if(this.ApellidoAdicional != null && this.ApellidoAdicional.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoAdicional, length must be less than 30.", new [] { "ApellidoAdicional" });
            }
            if(this.PrimerNombre != null && this.PrimerNombre.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrimerNombre, length must be less than 50.", new [] { "PrimerNombre" });
            }
            if(this.SegundoNombre != null && this.SegundoNombre.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SegundoNombre, length must be less than 50.", new [] { "SegundoNombre" });
            }
            if(this.RFC != null && this.RFC.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RFC, length must be less than 13.", new [] { "RFC" });
            }
            if(this.CURP != null && this.CURP.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CURP, length must be less than 18.", new [] { "CURP" });
            }
            if(this.ClaveElectorIFE != null && this.ClaveElectorIFE.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClaveElectorIFE, length must be less than 20.", new [] { "ClaveElectorIFE" });
            }
            yield break;
        }
    }
}
