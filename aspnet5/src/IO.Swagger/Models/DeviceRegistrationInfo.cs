/*
 * TestAPI
 *
 *  # Introduction   Welcome to the reference for my API!   <a href=\"http://en.wikipedia.org/wiki/REST_API\" target=\"_blank\">REST</a> is a web-service protocol that lends itself to rapid development by using everyday HTTP and JSON technology.   My REST API provides a broad set of operations and resources that:  * Enable x.  * Support y.  * Process z.   ## Endpoints   My API is provided via the following endpoints.   | Tenant                 | Base URL for REST Endpoints    |  |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|  | Production             | https://api.mydomain.com/v1    |  | API Sandbox            | https://sandbox.mydomain.com/v1|     The production endpoint provides access to your live user data. The API Sandbox tenant is a good place to test your code without affecting real-world data. To use it, you must be provisioned with an API Sandbox tenant.   ## Access to the API   If you have a tenant, you already have access to the API.   If you don't have a tenant, go to <a href=\"https://www.mydomain.com/resource/sandbox\" target=\"_blank\">https://www.mydomain.com/resource/sandbox</a> and sign up for a one. # Operations:  ## Basic Info  These are the basic operations for my API...   etc 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@swaggerhub.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DeviceRegistrationInfo :  IEquatable<DeviceRegistrationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRegistrationInfo" /> class.
        /// </summary>
        /// <param name="Uri">Uri.</param>
        /// <param name="Id">Id.</param>
        public DeviceRegistrationInfo(string Uri = null, Guid? Id = null)
        {
            this.Uri = Uri;
            this.Id = Id;
            
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public Guid? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceRegistrationInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DeviceRegistrationInfo)obj);
        }

        /// <summary>
        /// Returns true if DeviceRegistrationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceRegistrationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRegistrationInfo other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                    if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(DeviceRegistrationInfo left, DeviceRegistrationInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeviceRegistrationInfo left, DeviceRegistrationInfo right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
