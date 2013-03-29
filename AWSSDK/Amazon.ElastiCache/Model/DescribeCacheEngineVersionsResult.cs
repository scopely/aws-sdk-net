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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of the DescribeCacheEngineVersions action. </para>
    /// </summary>
    public class DescribeCacheEngineVersionsResult
    {
        
        private string marker;
        private List<CacheEngineVersion> cacheEngineVersions = new List<CacheEngineVersion>();

        /// <summary>
        /// The identifier returned to allow retrieval of paginated results.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeCacheEngineVersionsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <c>CacheEngineVersion</c> elements.
        ///  
        /// </summary>
        public List<CacheEngineVersion> CacheEngineVersions
        {
            get { return this.cacheEngineVersions; }
            set { this.cacheEngineVersions = value; }
        }
        /// <summary>
        /// Adds elements to the CacheEngineVersions collection
        /// </summary>
        /// <param name="cacheEngineVersions">The values to add to the CacheEngineVersions collection </param>
        /// <returns>this instance</returns>
        public DescribeCacheEngineVersionsResult WithCacheEngineVersions(params CacheEngineVersion[] cacheEngineVersions)
        {
            foreach (CacheEngineVersion element in cacheEngineVersions)
            {
                this.cacheEngineVersions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheEngineVersions collection
        /// </summary>
        /// <param name="cacheEngineVersions">The values to add to the CacheEngineVersions collection </param>
        /// <returns>this instance</returns>
        public DescribeCacheEngineVersionsResult WithCacheEngineVersions(IEnumerable<CacheEngineVersion> cacheEngineVersions)
        {
            foreach (CacheEngineVersion element in cacheEngineVersions)
            {
                this.cacheEngineVersions.Add(element);
            }

            return this;
        }

        // Check to see if CacheEngineVersions property is set
        internal bool IsSetCacheEngineVersions()
        {
            return this.cacheEngineVersions.Count > 0;
        }
    }
}
