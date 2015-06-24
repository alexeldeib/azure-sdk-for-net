// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// The parameters to the New Dedicated Circuit Link Authorization request.
    /// </summary>
    public partial class DedicatedCircuitLinkAuthorizationNewParameters
    {
        private string _description;
        
        /// <summary>
        /// Optional. Specifies the description associated with this
        /// authorization.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private int _limit;
        
        /// <summary>
        /// Optional. Number of dedicated circuit links allowed amongst all
        /// Microsoft Ids
        /// </summary>
        public int Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }
        
        private string _microsoftIds;
        
        /// <summary>
        /// Optional. Specifies a comma separated list of Microsoft Ids
        /// </summary>
        public string MicrosoftIds
        {
            get { return this._microsoftIds; }
            set { this._microsoftIds = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DedicatedCircuitLinkAuthorizationNewParameters class.
        /// </summary>
        public DedicatedCircuitLinkAuthorizationNewParameters()
        {
        }
    }
}