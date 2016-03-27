﻿// ReSharper disable InconsistentNaming

namespace DnsRip
{
    public partial class DnsRip
    {
        public enum InputType
        {
            Ip,
            Hostname,
            Invalid
        }

        public enum QueryType
        {
            A = 1
        }

        public enum OpCode
        {
            Query = 0,
        }

        public enum QueryClass
        {
            IN = 1
        }
    }
}