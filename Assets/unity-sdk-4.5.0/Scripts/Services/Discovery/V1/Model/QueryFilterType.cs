/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.Watson.Discovery.V1.Model
{
    /// <summary>
    /// QueryFilterType.
    /// </summary>
    public class QueryFilterType
    {
        /// <summary>
        /// A comma-separated list of types to exclude.
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclude { get; set; }
        /// <summary>
        /// A comma-separated list of types to include. All other types are excluded.
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Include { get; set; }
    }
}
