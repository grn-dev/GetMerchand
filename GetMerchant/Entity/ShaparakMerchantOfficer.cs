using Newtonsoft.Json;
using GetMerchant.Enums;
using System;
using GetMerchant.tools;

namespace GetMerchant.Entity
{
    public class ShaparakMerchantOfficer
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

      
        [JsonProperty("nationalCode")]
        public string NationalCode { get; set; }

         
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
         
        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

        //public string ToJson() => this.SerializeToString();
    }
}