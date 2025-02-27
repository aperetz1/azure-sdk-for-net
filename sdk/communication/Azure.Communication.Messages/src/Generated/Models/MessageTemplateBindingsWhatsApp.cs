// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The template bindings for WhatsApp. </summary>
    internal partial class MessageTemplateBindingsWhatsApp
    {
        /// <summary> Initializes a new instance of MessageTemplateBindingsWhatsApp. </summary>
        public MessageTemplateBindingsWhatsApp()
        {
            Header = new ChangeTrackingList<MessageTemplateBindingsWhatsAppComponent>();
            Body = new ChangeTrackingList<MessageTemplateBindingsWhatsAppComponent>();
            Footer = new ChangeTrackingList<MessageTemplateBindingsWhatsAppComponent>();
            Button = new ChangeTrackingList<MessageTemplateBindingsWhatsAppButton>();
        }

        /// <summary> Gets the header. </summary>
        public IList<MessageTemplateBindingsWhatsAppComponent> Header { get; }
        /// <summary> Gets the body. </summary>
        public IList<MessageTemplateBindingsWhatsAppComponent> Body { get; }
        /// <summary> Gets the footer. </summary>
        public IList<MessageTemplateBindingsWhatsAppComponent> Footer { get; }
        /// <summary> Gets the button. </summary>
        public IList<MessageTemplateBindingsWhatsAppButton> Button { get; }
    }
}
