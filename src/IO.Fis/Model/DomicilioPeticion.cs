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
    public partial class DomicilioPeticion :  IEquatable<DomicilioPeticion>, IValidatableObject
    {

        [JsonConstructorAttribute]
        protected DomicilioPeticion() { }

        public DomicilioPeticion(string direccion = default(string), string coloniaPoblacion = default(string), string delegacionMunicipio = default(string), string ciudad = default(string), CatalogoEstados estado = default(CatalogoEstados), string cP = default(string), string fechaResidencia = default(string), string numeroTelefono = default(string), CatalogoTipoDomicilio? tipoDomicilio = default(CatalogoTipoDomicilio?), CatalogoTipoAsentamiento? tipoAsentamiento = default(CatalogoTipoAsentamiento?))
        {
          
            this.Direccion = direccion;        
            this.ColoniaPoblacion = coloniaPoblacion;
            this.DelegacionMunicipio = delegacionMunicipio;
            this.Ciudad = ciudad;    
            this.Estado = estado;        
            this.CP = cP;          
            this.FechaResidencia = fechaResidencia;
            this.NumeroTelefono = numeroTelefono;
            this.TipoDomicilio = tipoDomicilio;
            this.TipoAsentamiento = tipoAsentamiento;
        }

        [DataMember(Name="direccion", EmitDefaultValue=false)]
        public string Direccion { get; set; }
        [DataMember(Name="coloniaPoblacion", EmitDefaultValue=false)]
        public string ColoniaPoblacion { get; set; }
        [DataMember(Name="delegacionMunicipio", EmitDefaultValue=false)]
        public string DelegacionMunicipio { get; set; }
        [DataMember(Name="ciudad", EmitDefaultValue=false)]
        public string Ciudad { get; set; }
        [DataMember(Name="estado", EmitDefaultValue=false)]
        public CatalogoEstados Estado { get; set; }
        [DataMember(Name="CP", EmitDefaultValue=false)]
        public string CP { get; set; }
        [DataMember(Name="fechaResidencia", EmitDefaultValue=false)]
        public string FechaResidencia { get; set; }
        [DataMember(Name="numeroTelefono", EmitDefaultValue=false)]
        public string NumeroTelefono { get; set; }
        [DataMember(Name="tipoDomicilio", EmitDefaultValue=false)]
        public CatalogoTipoDomicilio? TipoDomicilio { get; set; }
        [DataMember(Name="tipoAsentamiento", EmitDefaultValue=false)]
        public CatalogoTipoAsentamiento? TipoAsentamiento { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomicilioPeticion {\n");
            sb.Append("  Direccion: ").Append(Direccion).Append("\n");
            sb.Append("  ColoniaPoblacion: ").Append(ColoniaPoblacion).Append("\n");
            sb.Append("  DelegacionMunicipio: ").Append(DelegacionMunicipio).Append("\n");
            sb.Append("  Ciudad: ").Append(Ciudad).Append("\n");
            sb.Append("  Estado: ").Append(Estado).Append("\n");
            sb.Append("  CP: ").Append(CP).Append("\n");
            sb.Append("  FechaResidencia: ").Append(FechaResidencia).Append("\n");
            sb.Append("  NumeroTelefono: ").Append(NumeroTelefono).Append("\n");
            sb.Append("  TipoDomicilio: ").Append(TipoDomicilio).Append("\n");
            sb.Append("  TipoAsentamiento: ").Append(TipoAsentamiento).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DomicilioPeticion);
        }
        public bool Equals(DomicilioPeticion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Direccion == input.Direccion ||
                    (this.Direccion != null &&
                    this.Direccion.Equals(input.Direccion))
                ) && 
                (
                    this.ColoniaPoblacion == input.ColoniaPoblacion ||
                    (this.ColoniaPoblacion != null &&
                    this.ColoniaPoblacion.Equals(input.ColoniaPoblacion))
                ) && 
                (
                    this.DelegacionMunicipio == input.DelegacionMunicipio ||
                    (this.DelegacionMunicipio != null &&
                    this.DelegacionMunicipio.Equals(input.DelegacionMunicipio))
                ) && 
                (
                    this.Ciudad == input.Ciudad ||
                    (this.Ciudad != null &&
                    this.Ciudad.Equals(input.Ciudad))
                ) && 
                (
                    this.Estado == input.Estado ||
                    (this.Estado != null &&
                    this.Estado.Equals(input.Estado))
                ) && 
                (
                    this.CP == input.CP ||
                    (this.CP != null &&
                    this.CP.Equals(input.CP))
                ) && 
                (
                    this.FechaResidencia == input.FechaResidencia ||
                    (this.FechaResidencia != null &&
                    this.FechaResidencia.Equals(input.FechaResidencia))
                ) && 
                (
                    this.NumeroTelefono == input.NumeroTelefono ||
                    (this.NumeroTelefono != null &&
                    this.NumeroTelefono.Equals(input.NumeroTelefono))
                ) && 
                (
                    this.TipoDomicilio == input.TipoDomicilio ||
                    (this.TipoDomicilio != null &&
                    this.TipoDomicilio.Equals(input.TipoDomicilio))
                ) && 
                (
                    this.TipoAsentamiento == input.TipoAsentamiento ||
                    (this.TipoAsentamiento != null &&
                    this.TipoAsentamiento.Equals(input.TipoAsentamiento))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Direccion != null)
                    hashCode = hashCode * 59 + this.Direccion.GetHashCode();
                if (this.ColoniaPoblacion != null)
                    hashCode = hashCode * 59 + this.ColoniaPoblacion.GetHashCode();
                if (this.DelegacionMunicipio != null)
                    hashCode = hashCode * 59 + this.DelegacionMunicipio.GetHashCode();
                if (this.Ciudad != null)
                    hashCode = hashCode * 59 + this.Ciudad.GetHashCode();
                if (this.Estado != null)
                    hashCode = hashCode * 59 + this.Estado.GetHashCode();
                if (this.CP != null)
                    hashCode = hashCode * 59 + this.CP.GetHashCode();
                if (this.FechaResidencia != null)
                    hashCode = hashCode * 59 + this.FechaResidencia.GetHashCode();
                if (this.NumeroTelefono != null)
                    hashCode = hashCode * 59 + this.NumeroTelefono.GetHashCode();
                if (this.TipoDomicilio != null)
                    hashCode = hashCode * 59 + this.TipoDomicilio.GetHashCode();
                if (this.TipoAsentamiento != null)
                    hashCode = hashCode * 59 + this.TipoAsentamiento.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.Direccion != null && this.Direccion.Length > 85)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Direccion, length must be less than 85.", new [] { "Direccion" });
            }
            if(this.ColoniaPoblacion != null && this.ColoniaPoblacion.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ColoniaPoblacion, length must be less than 65.", new [] { "ColoniaPoblacion" });
            }
            if(this.DelegacionMunicipio != null && this.DelegacionMunicipio.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DelegacionMunicipio, length must be less than 65.", new [] { "DelegacionMunicipio" });
            }
            if(this.Ciudad != null && this.Ciudad.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ciudad, length must be less than 65.", new [] { "Ciudad" });
            }
            if(this.CP != null && this.CP.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CP, length must be less than 5.", new [] { "CP" });
            }
            if(this.CP != null && this.CP.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CP, length must be greater than 5.", new [] { "CP" });
            }
            if(this.NumeroTelefono != null && this.NumeroTelefono.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroTelefono, length must be less than 20.", new [] { "NumeroTelefono" });
            }
            yield break;
        }
    }
}
