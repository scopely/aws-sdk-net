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
    /// <para>Represents the output from a DescribeCacheSubnetGroups action.</para>
    /// </summary>
    public class DescribeCacheSubnetGroupsResult
    {
        
        private string marker;
        private List<CacheSubnetGroup> cacheSubnetGroups = new List<CacheSubnetGroup>();

        /// <summary>
        /// The marker obtained from a previous operation response.
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
        public DescribeCacheSubnetGroupsResult WithMarker(string marker)
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
        /// One or more Cache Subnet Groups.
        ///  
        /// </summary>
        public List<CacheSubnetGroup> CacheSubnetGroups
        {
            get { return this.cacheSubnetGroups; }
            set { this.cacheSubnetGroups = value; }
        }
        /// <summary>
        /// Adds elements to the CacheSubnetGroups collection
        /// </summary>
        /// <param name="cacheSubnetGroups">The values to add to the CacheSubnetGroups collection </param>
        /// <returns>this instance</returns>
        public DescribeCacheSubnetGroupsResult WithCacheSubnetGroups(params CacheSubnetGroup[] cacheSubnetGroups)
        {
            foreach (CacheSubnetGroup element in cacheSubnetGroups)
            {
                this.cacheSubnetGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheSubnetGroups collection
        /// </summary>
        /// <param name="cacheSubnetGroups">The values to add to the CacheSubnetGroups collection </param>
        /// <returns>this instance</returns>
        public DescribeCacheSubnetGroupsResult WithCacheSubnetGroups(IEnumerable<CacheSubnetGroup> cacheSubnetGroups)
        {
            foreach (CacheSubnetGroup element in cacheSubnetGroups)
            {
                this.cacheSubnetGroups.Add(element);
            }

            return this;
        }

        // Check to see if CacheSubnetGroups property is set
        internal bool IsSetCacheSubnetGroups()
        {
            return this.cacheSubnetGroups.Count > 0;
        }
    }
}
