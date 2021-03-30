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
        public string FirstNameFa { get; set; }

         
        [JsonProperty("lastNameFa")]
        public string LastNameFa { get; set; }

        
        [JsonProperty("fatherNameFa")]
        public string FatherNameFa { get; set; }
         
        [JsonProperty("firstNameEn")]
        public string FirstNameEn { get; set; }

        
        [JsonProperty("lastNameEn")]
        public string LastNameEn { get; set; }

         
        [JsonProperty("fatherNameEn")]
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
        public string NationalCode { get; set; }

         
        [JsonProperty("registerNumber"), MaxLength(50)]
        public string RegisterNumber { get; set; }

        
        [JsonProperty("comNameFa")]
        public string CompanyNameFa { get; set; }

         
        [JsonProperty("comNameEn")]
        public string CompanyNameEn { get; set; }

 
        [JsonProperty("merchantType")]
        public ShaparakMerchantIdentityType MerchantType { get; set; }

         
        [JsonProperty("residencyType")]
        public ShaparakResidencyType ResidencyType { get; set; }
         
        [JsonProperty("vitalStatus")]
        public ShaparakVitalStatus? VitalStatus { get; set; }

         
        [JsonProperty("birthCrtfctNumber")]
        public int? BirthCertificateNumber { get; set; }

         
        [JsonProperty("birthCrtfctSerial")]
        public int? BirthCertificateSerial { get; set; }

         
        [JsonProperty("birthCrtfctSeriesLetter")]
        public ShaparakIdCertificateLetter? BirthCertificateSeriesLetter { get; set; }
 
        [JsonProperty("birthCrtfctSeriesNumber")]
        public int? BirthCertificateSeriesNumber { get; set; }
         
        [JsonProperty("nationalLegalCode")]
        public string NationalLegalCode { get; set; }
 
        [JsonProperty("commercialCode")]
        public string CommercialCode { get; set; }
 
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
 
        [JsonProperty("foreignPervasiveCode")]
        public string ForeignPervasiveCode { get; set; }

         
        [JsonProperty("passportNumber")]
        public string PassportNumber { get; set; }

       
        [JsonProperty("passportExpireDate")]
        public long? PassportExpireDate => PassportExpireDateValue?.ToTimestamp3();
  
        [JsonIgnore]
        public DateTime? PassportExpireDateValue { get; set; }
 
        [JsonProperty("Description")]
        public string Description { get; set; }

        [Required, MinLength(9), MaxLength(12)]
        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [Required , MinLength(11), MaxLength(11)]
        [JsonProperty("cellPhoneNumber")]
        public string Mobile { get; set; }
         
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
         
        [JsonProperty("webSite")]
        public string Website { get; set; }
         
        [JsonProperty("fax")]
        public string Fax { get; set; }

         
        [JsonProperty("merchantIbans")]
        public List<ShaparakMerchantIbanInfo> Ibans { get; set; }

        
        [JsonProperty("merchantOfficers")]
        public List<ShaparakMerchantOfficer> Officers { get; set; }

         
        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

        public string ToJson() => this.SerializeToString();
    }
}