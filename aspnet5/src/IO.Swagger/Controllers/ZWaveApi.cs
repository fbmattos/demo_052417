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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class ZWaveApiController : Controller
    { 

        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">ok</response>
        [HttpGet]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lightingSummary")]
        [SwaggerOperation("GetLightingSummary")]
        [SwaggerResponse(200, type: typeof(LightingSummary))]
        public virtual IActionResult GetLightingSummary()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LightingSummary>(exampleJson)
            : default(LightingSummary);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <response code="200">response</response>
        [HttpGet]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lighting/switches/{deviceId}")]
        [SwaggerOperation("GetSwitchState")]
        [SwaggerResponse(200, type: typeof(DeviceState))]
        public virtual IActionResult GetSwitchState([FromRoute]string deviceId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DeviceState>(exampleJson)
            : default(DeviceState);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lighting/dimmers/{deviceId}/{value}")]
        [SwaggerOperation("SetDimmer")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult SetDimmer([FromRoute]string deviceId, [FromRoute]int? value)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>sets a dimmer to a specific value on a timer</remarks>
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <param name="timeunit"></param>
        /// <param name="units"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lighting/dimmers/{deviceId}/{value}/timer/{timeunit}")]
        [SwaggerOperation("SetDimmerTimer")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult SetDimmerTimer([FromRoute]string deviceId, [FromRoute]int? value, [FromRoute]int? timeunit, [FromQuery]string units)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lighting/switches/{deviceId}/{value}")]
        [SwaggerOperation("SetSwitch")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult SetSwitch([FromRoute]string deviceId, [FromRoute]string value)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>sets a switch to a specific value on a timer</remarks>
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <param name="minutes"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/swaggerhub-support/test_05242017/1.0.0/lighting/switches/{deviceId}/{value}/timer/{minutes}")]
        [SwaggerOperation("SetSwitchTimer")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult SetSwitchTimer([FromRoute]string deviceId, [FromRoute]string value, [FromRoute]int? minutes)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }
    }
}
