﻿namespace _19_07_2023_task1.Models
{
    public class ReceivedSubject
    {
        public string? Name { get; set; }
        public string? Nip { get; set; }
        public string? StatusVat { get; set; }
        public string? Regon { get; set; }
        public string? Pesel { get; set; }
        public string? Krs { get; set; }
        public string? ResidenceAddress { get; set; }
        public string? WorkingAddress { get; set; }
        public List<object>? Representatives { get; set; }
        public List<object>? AuthorizedClerks { get; set; }
        public List<object>? Partners { get; set; }
        public string? RegistrationLegalDate { get; set; }
        public string? RegistrationDenialBasis { get; set; }
        public string? RegistrationDenialDate { get; set; }
        public string? RestorationBasis { get; set; }
        public string? RestorationDate { get; set; }
        public string? RemovalBasis { get; set; }
        public string? RemovalDate { get; set; }
        public List<string>? AccountNumbers { get; set; }
        public bool? HasVirtualAccounts { get; set; }
    }
}
