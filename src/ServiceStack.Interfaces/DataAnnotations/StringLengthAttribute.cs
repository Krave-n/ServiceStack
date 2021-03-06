﻿// Copyright (c) Service Stack LLC. All Rights Reserved.
// License: https://raw.github.com/ServiceStack/ServiceStack/master/license.txt


namespace ServiceStack.DataAnnotations
{
    public class StringLengthAttribute : AttributeBase
    {
        public const int MaxText = int.MaxValue;
        public int MinimumLength { get; set; }
        public int MaximumLength { get; private set; }

        public StringLengthAttribute(int maximumLength)
        {
            MaximumLength = maximumLength;
        }
    }
}