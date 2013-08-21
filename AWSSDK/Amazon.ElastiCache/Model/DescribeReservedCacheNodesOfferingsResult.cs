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
    /// <para> Contains the result of a successful invocation of the DescribeReservedCacheNodesOfferings action. </para>
    /// </summary>
    public class DescribeReservedCacheNodesOfferingsResult
    {
        
        private string marker;
        private List<ReservedCacheNodesOffering> reservedCacheNodesOfferings = new List<ReservedCacheNodesOffering>();

        /// <summary>
        /// A marker provided for paginated results.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedCacheNodesOfferingsResult WithMarker(string marker)
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
        /// A list of reserved Cache Node offerings.
        ///  
        /// </summary>
        public List<ReservedCacheNodesOffering> ReservedCacheNodesOfferings
        {
            get { return this.reservedCacheNodesOfferings; }
            set { this.reservedCacheNodesOfferings = value; }
        }
        /// <summary>
        /// Adds elements to the ReservedCacheNodesOfferings collection
        /// </summary>
        /// <param name="reservedCacheNodesOfferings">The values to add to the ReservedCacheNodesOfferings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedCacheNodesOfferingsResult WithReservedCacheNodesOfferings(params ReservedCacheNodesOffering[] reservedCacheNodesOfferings)
        {
            foreach (ReservedCacheNodesOffering element in reservedCacheNodesOfferings)
            {
                this.reservedCacheNodesOfferings.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ReservedCacheNodesOfferings collection
        /// </summary>
        /// <param name="reservedCacheNodesOfferings">The values to add to the ReservedCacheNodesOfferings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedCacheNodesOfferingsResult WithReservedCacheNodesOfferings(IEnumerable<ReservedCacheNodesOffering> reservedCacheNodesOfferings)
        {
            foreach (ReservedCacheNodesOffering element in reservedCacheNodesOfferings)
            {
                this.reservedCacheNodesOfferings.Add(element);
            }

            return this;
        }

        // Check to see if ReservedCacheNodesOfferings property is set
        internal bool IsSetReservedCacheNodesOfferings()
        {
            return this.reservedCacheNodesOfferings.Count > 0;
        }
    }
}
