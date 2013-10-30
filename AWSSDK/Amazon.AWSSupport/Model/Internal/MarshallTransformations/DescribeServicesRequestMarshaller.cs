/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Services Request Marshaller
    /// </summary>       
    internal class DescribeServicesRequestMarshaller : IMarshaller<IRequest, DescribeServicesRequest> 
    {
        

        public IRequest Marshall(DescribeServicesRequest describeServicesRequest) 
        {

            IRequest request = new DefaultRequest(describeServicesRequest, "AmazonAWSSupport");
            string target = "AWSSupport_20130415.DescribeServices";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                

                if (describeServicesRequest != null && describeServicesRequest.ServiceCodeList != null && describeServicesRequest.ServiceCodeList.Count > 0) 
                {
                    List<string> serviceCodeListList = describeServicesRequest.ServiceCodeList;
                    writer.WritePropertyName("serviceCodeList");
                    writer.WriteArrayStart();

                    foreach (string serviceCodeListListValue in serviceCodeListList) 
                    { 
                        writer.Write(StringUtils.FromString(serviceCodeListListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (describeServicesRequest != null && describeServicesRequest.IsSetLanguage()) 
                {
                    writer.WritePropertyName("language");
                    writer.Write(describeServicesRequest.Language);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
