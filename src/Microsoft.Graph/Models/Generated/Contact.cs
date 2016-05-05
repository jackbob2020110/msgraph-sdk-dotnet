// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    /// <summary>
    /// The type Contact.
    /// </summary>
    [DataContract]
    public partial class Contact : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [DataMember(Name = "parentFolderId", EmitDefaultValue = false, IsRequired = false)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets file as.
        /// </summary>
        [DataMember(Name = "fileAs", EmitDefaultValue = false, IsRequired = false)]
        public string FileAs { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// </summary>
        [DataMember(Name = "givenName", EmitDefaultValue = false, IsRequired = false)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets initials.
        /// </summary>
        [DataMember(Name = "initials", EmitDefaultValue = false, IsRequired = false)]
        public string Initials { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false, IsRequired = false)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets nick name.
        /// </summary>
        [DataMember(Name = "nickName", EmitDefaultValue = false, IsRequired = false)]
        public string NickName { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        [DataMember(Name = "surname", EmitDefaultValue = false, IsRequired = false)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets yomi given name.
        /// </summary>
        [DataMember(Name = "yomiGivenName", EmitDefaultValue = false, IsRequired = false)]
        public string YomiGivenName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi surname.
        /// </summary>
        [DataMember(Name = "yomiSurname", EmitDefaultValue = false, IsRequired = false)]
        public string YomiSurname { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company name.
        /// </summary>
        [DataMember(Name = "yomiCompanyName", EmitDefaultValue = false, IsRequired = false)]
        public string YomiCompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets generation.
        /// </summary>
        [DataMember(Name = "generation", EmitDefaultValue = false, IsRequired = false)]
        public string Generation { get; set; }
    
        /// <summary>
        /// Gets or sets email addresses.
        /// </summary>
        [DataMember(Name = "emailAddresses", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<EmailAddress> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets im addresses.
        /// </summary>
        [DataMember(Name = "imAddresses", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> ImAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = false, IsRequired = false)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false, IsRequired = false)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = false, IsRequired = false)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [DataMember(Name = "officeLocation", EmitDefaultValue = false, IsRequired = false)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// </summary>
        [DataMember(Name = "profession", EmitDefaultValue = false, IsRequired = false)]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets business home page.
        /// </summary>
        [DataMember(Name = "businessHomePage", EmitDefaultValue = false, IsRequired = false)]
        public string BusinessHomePage { get; set; }
    
        /// <summary>
        /// Gets or sets assistant name.
        /// </summary>
        [DataMember(Name = "assistantName", EmitDefaultValue = false, IsRequired = false)]
        public string AssistantName { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false, IsRequired = false)]
        public string Manager { get; set; }
    
        /// <summary>
        /// Gets or sets home phones.
        /// </summary>
        [DataMember(Name = "homePhones", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> HomePhones { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = false, IsRequired = false)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// </summary>
        [DataMember(Name = "businessPhones", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets home address.
        /// </summary>
        [DataMember(Name = "homeAddress", EmitDefaultValue = false, IsRequired = false)]
        public PhysicalAddress HomeAddress { get; set; }
    
        /// <summary>
        /// Gets or sets business address.
        /// </summary>
        [DataMember(Name = "businessAddress", EmitDefaultValue = false, IsRequired = false)]
        public PhysicalAddress BusinessAddress { get; set; }
    
        /// <summary>
        /// Gets or sets other address.
        /// </summary>
        [DataMember(Name = "otherAddress", EmitDefaultValue = false, IsRequired = false)]
        public PhysicalAddress OtherAddress { get; set; }
    
        /// <summary>
        /// Gets or sets spouse name.
        /// </summary>
        [DataMember(Name = "spouseName", EmitDefaultValue = false, IsRequired = false)]
        public string SpouseName { get; set; }
    
        /// <summary>
        /// Gets or sets personal notes.
        /// </summary>
        [DataMember(Name = "personalNotes", EmitDefaultValue = false, IsRequired = false)]
        public string PersonalNotes { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> Children { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// </summary>
        [DataMember(Name = "photo", EmitDefaultValue = false, IsRequired = false)]
        public ProfilePhoto Photo { get; set; }
    
    }
}

