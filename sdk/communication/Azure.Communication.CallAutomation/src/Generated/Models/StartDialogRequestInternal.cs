// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The StartDialogRequest. </summary>
    internal partial class StartDialogRequestInternal
    {
        /// <summary> Initializes a new instance of StartDialogRequestInternal. </summary>
        /// <param name="dialogOptions"> Defines options for dialog. </param>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dialogOptions"/> is null. </exception>
        public StartDialogRequestInternal(DialogOptionsInternal dialogOptions, DialogInputType dialogInputType)
        {
            Argument.AssertNotNull(dialogOptions, nameof(dialogOptions));

            DialogOptions = dialogOptions;
            DialogInputType = dialogInputType;
        }

        /// <summary> Defines options for dialog. </summary>
        public DialogOptionsInternal DialogOptions { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType DialogInputType { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
