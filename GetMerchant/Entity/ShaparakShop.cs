using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using GetMerchant.tools;
using GetMerchant.Enums;

namespace GetMerchant.Entity
{
    public class ShaparakShop
    {

        [Required, MinLength(1), MaxLength(50)]
        [JsonProperty("farsiName")]
        public string FarsiName { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [Required, MinLength(9), MaxLength(12)]
        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [Required, MinLength(10), MaxLength(10)]
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [MaxLength(50)]
        [JsonProperty("businessCertificateNumber")]
        public string BusinessCertificateNumber { get; set; }

        [JsonProperty("certificateIssueDate")]
        public long? CertificateIssueDate => CertificateIssueDateValue?.ToTimestamp3();


        [JsonIgnore]
        public DateTime? CertificateIssueDateValue { get; set; }

        [JsonProperty("certificateExpiryDate")]
        public long? CertificateExpiryDate => CertificateExpiryDateValue?.ToTimestamp3();


        [JsonIgnore]
        public DateTime? CertificateExpiryDateValue { get; set; }


        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("businessCategoryCode")]
        public string BusinessCategoryCode { get; set; }

        [Required, MinLength(1), MaxLength(4)]
        [JsonProperty("businessSubCategoryCode")]
        public string BusinessSubCategoryCode { get; set; }

        [JsonProperty("ownershipType")]
        public ShaparakBusinessOwnershipType OwnershipType { get; set; }


        [MaxLength(50)]
        [JsonProperty("rentalContractNumber")]
        public string RentalContractNumber { get; set; }


        [JsonProperty("rentalExpiryDate"),]
        public long? RentalExpiryDate => RentalExpiryDateValue?.ToTimestamp3();

        public DateTime? RentalExpiryDateValue { get; set; }


        [MaxLength(255)]
        [JsonProperty("Address")]
        public string Address { get; set; }

        [Required, MinLength(2), MaxLength(2)]
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }


        [MaxLength(3)]
        [JsonProperty("provinceCode")]
        public string ProvinceCode { get; set; }

        [MaxLength(6)]
        [JsonProperty("cityCode")]
        public string CityCode { get; set; }

        [Required,]
        [JsonProperty("businessType")]
        public ShaparakShopType BusinessType { get; set; }


        [JsonProperty("etrustCertificateType")]
        public ShaparakEtrustCertificateType? EtrustCertificateType { get; set; }


        [JsonProperty("etrustCertificateIssueDate")]
        public long? EtrustCertificateIssueDate => EtrustCertificateIssueDateValue?.ToTimestamp3();


        [JsonIgnore]
        public DateTime? EtrustCertificateIssueDateValue { get; set; }

        [JsonProperty("etrustCertificateExpiryDate")]
        public long? EtrustCertificateExpiryDate => EtrustCertificateExpiryDateValue?.ToTimestamp3();


        [JsonIgnore]
        public DateTime? EtrustCertificateExpiryDateValue { get; set; }


        [MinLength(6), MaxLength(255)]
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }


        [MinLength(6), MaxLength(255)]
        [JsonProperty("websiteAddress")]
        public string WebsiteAddress { get; set; }


        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

        public string ToJson() => this.SerializeToString();
    }
}