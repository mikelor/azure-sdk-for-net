// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The error details. </summary>
    public partial class ServiceResponseBaseError : ErrorResponse
    {
        /// <summary> Initializes a new instance of ServiceResponseBaseError. </summary>
        internal ServiceResponseBaseError()
        {
        }

        /// <summary> Initializes a new instance of ServiceResponseBaseError. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="details"> An array of error detail objects. </param>
        internal ServiceResponseBaseError(string code, string message, IReadOnlyList<ErrorDetail> details) : base(code, message, details)
        {
        }
    }
}