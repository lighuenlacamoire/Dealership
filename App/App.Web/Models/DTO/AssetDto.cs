using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models.DTO
{
    public class AssetDto
    {
        public string Id { get; set; }
        [StringLength(50, ErrorMessage = "El Id del Dispositivo puede contener un maximo 50 caracteres.")]
        [Required(ErrorMessage = "El EntityCode es obligatorio.")]
        public string EntityCode { get; set; } //device id
        [StringLength(50, ErrorMessage = "La descripcion puede contener un maximo de 50 caracteres.")]
        [Required(ErrorMessage = "La descripcion es obligatoria.")]
        public string Description { get; set; } //Descripcion generica
        [Required(ErrorMessage = "El tipo de Activo es obligatorio.")]
        public string AssetTypeId { get; set; } //ref AssetTypeDto
        [Required(ErrorMessage = "El valor del Campo indentificador es obligatorio")]
        public string AssetIdentifier { get; set; } //representa el valor
        [Required(ErrorMessage = "El Tenant es obligatorio.")]
        public string TenantId { get; set; } //TenantId _id de Mongo
        public string FileIconId { get; set; } //_id de Mongo
        public string SuperTenantId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsActive { get; set; }

    }
}
