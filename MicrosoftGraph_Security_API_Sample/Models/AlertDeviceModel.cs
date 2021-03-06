﻿/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using System.Net;

namespace MicrosoftGraph_Security_API_Sample.Models
{
    public class AlertDeviceModel
    {
        public string Fqdn { get; set; }
        public bool? IsAzureDomainJoined { get; set; }
        public string PrivateIpAddress { get; set; }
        public string PublicIpAddress { get; set; }
    }
}