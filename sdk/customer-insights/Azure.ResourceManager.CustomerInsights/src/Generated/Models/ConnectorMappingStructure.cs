// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Connector mapping property structure. </summary>
    public partial class ConnectorMappingStructure
    {
        /// <summary> Initializes a new instance of ConnectorMappingStructure. </summary>
        /// <param name="propertyName"> The property name of the mapping entity. </param>
        /// <param name="columnName"> The column name of the import file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="propertyName"/> or <paramref name="columnName"/> is null. </exception>
        public ConnectorMappingStructure(string propertyName, string columnName)
        {
            Argument.AssertNotNull(propertyName, nameof(propertyName));
            Argument.AssertNotNull(columnName, nameof(columnName));

            PropertyName = propertyName;
            ColumnName = columnName;
        }

        /// <summary> Initializes a new instance of ConnectorMappingStructure. </summary>
        /// <param name="propertyName"> The property name of the mapping entity. </param>
        /// <param name="columnName"> The column name of the import file. </param>
        /// <param name="customFormatSpecifier"> Custom format specifier for input parsing. </param>
        /// <param name="isEncrypted"> Indicates if the column is encrypted. </param>
        internal ConnectorMappingStructure(string propertyName, string columnName, string customFormatSpecifier, bool? isEncrypted)
        {
            PropertyName = propertyName;
            ColumnName = columnName;
            CustomFormatSpecifier = customFormatSpecifier;
            IsEncrypted = isEncrypted;
        }

        /// <summary> The property name of the mapping entity. </summary>
        public string PropertyName { get; set; }
        /// <summary> The column name of the import file. </summary>
        public string ColumnName { get; set; }
        /// <summary> Custom format specifier for input parsing. </summary>
        public string CustomFormatSpecifier { get; set; }
        /// <summary> Indicates if the column is encrypted. </summary>
        public bool? IsEncrypted { get; set; }
    }
}
