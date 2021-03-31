using Newtonsoft.Json;
using GetMerchant.Enums;
using GetMerchant.tools;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GetMerchant.Entity
{
    public class ShaparakMerchant
    {
        
        [JsonProperty("firstNameFa")]
        [MaxLength(50)]
        public string FirstNameFa { get; set; }

         
        [JsonProperty("lastNameFa")]
        [MaxLength(50)]
        public string LastNameFa { get; set; }

        
        [JsonProperty("fatherNameFa")]
        [MaxLength(50)]
        public string FatherNameFa { get; set; }
         
        [JsonProperty("firstNameEn")]
        [MaxLength(50)]
        public string FirstNameEn { get; set; }

        
        [JsonProperty("lastNameEn")]
        [MaxLength(50)]
        public string LastNameEn { get; set; }

         
        [JsonProperty("fatherNameEn")]
        [MaxLength(50)]
        public string FatherNameEn { get; set; }
         

        [JsonProperty("gender")]
        public ShaparakGender? Gender { get; set; }

        
        [JsonProperty("birthDate")]
        public long? BirthDate => BirthDateValue?.ToTimestamp3();
 
        [JsonIgnore]
        public DateTime? BirthDateValue { get; set; }

         
        [JsonProperty("registerDate")]
        public long? RegisterDate => RegisterDateValue?.ToTimestamp3();

         
        [JsonIgnore]
        public DateTime? RegisterDateValue { get; set; }

         
        [JsonProperty("nationalCode")]
        [MaxLength(10)]
        public string NationalCode { get; set; }

         
        [JsonProperty("registerNumber"), MaxLength(50)]
        public string RegisterNumber { get; set; }

        
        [JsonProperty("comNameFa")]
        [MaxLength(50)]
        public string CompanyNameFa { get; set; }

         
        [JsonProperty("comNameEn")]
        [MaxLength(50)]
        public string CompanyNameEn { get; set; }

 
        [JsonProperty("merchantType")]
        public ShaparakMerchantIdentityType MerchantType { get; set; }

         
        [JsonProperty("residencyType")]
        public ShaparakResidencyType ResidencyType { get; set; }
         
        [JsonProperty("vitalStatus")]
        public ShaparakVitalStatus? VitalStatus { get; set; }

         
        [JsonProperty("birthCrtfctNumber"),MaxLength(10),MinLength(1)]
        public int? BirthCertificateNumber { get; set; }

         
        [JsonProperty("birthCrtfctSerial"), MaxLength(6), MinLength(6)]
        public int? BirthCertificateSerial { get; set; }

         
        [JsonProperty("birthCrtfctSeriesLetter")]
        public ShaparakIdCertificateLetter? BirthCertificateSeriesLetter { get; set; }
 
        [JsonProperty("birthCrtfctSeriesNumber")]
        public int? BirthCertificateSeriesNumber { get; set; }
         

        [JsonProperty("nationalLegalCode")]
        [MaxLength(11),MinLength(11)]
        public string NationalLegalCode { get; set; }
 
        [JsonProperty("commercialCode")]
        [MaxLength(50), MinLength(1)]
        public string CommercialCode { get; set; }
 
        [JsonProperty("countryCode")]
        [MaxLength(2), MinLength(2)]
        public string CountryCode { get; set; }
 
        [JsonProperty("foreignPervasiveCode")]
        [MaxLength(50), MinLength(1)]
        public string ForeignPervasiveCode { get; set; }

         
        [JsonProperty("passportNumber")]
        [MaxLength(50), MinLength(1)]
        public string PassportNumber { get; set; }

       
        [JsonProperty("passportExpireDate")]
        public long? PassportExpireDate => PassportExpireDateValue?.ToTimestamp3();
  
        [JsonIgnore]
        public DateTime? PassportExpireDateValue { get; set; }
 
        [JsonProperty("Description")]
        [MaxLength(255), MinLength(1)]
        public string Description { get; set; }

        [Required, MinLength(9), MaxLength(12)]
        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [Required , MinLength(11), MaxLength(11)]
        [JsonProperty("cellPhoneNumber")]
        public string Mobile { get; set; }
         
        [JsonProperty("emailAddress")]
        [MaxLength(100), MinLength(3)]
        public string EmailAddress { get; set; }
         
        [JsonProperty("webSite")]
        [MaxLength(100), MinLength(3)]
        public string Website { get; set; }
         
        [JsonProperty("fax")]
        [MaxLength(12), MinLength(9)]
        public string Fax { get; set; }

         
        [JsonProperty("merchantIbans")]
        public List<ShaparakMerchantIbanInfo> Ibans { get; set; }

        
        [JsonProperty("merchantOfficers")]
        public List<ShaparakMerchantOfficer> Officers { get; set; }


        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

        //public string ToJson() => this.SerializeToString();
    }
}