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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnection operation.
    /// <para>Creates a new connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection links your
    /// internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
    /// is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web Services in
    /// the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a connection in
    /// one region does not provide connectivity to other regions.</para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonDirectConnectRequest
    {
        private string location;
        private string bandwidth;
        private string connectionName;


        /// <summary>
        /// Where the connection is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gbps Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this.bandwidth != null;
        }

        /// <summary>
        /// The name of the connection. Example: "<i>1G Connection to AWS</i>" Default: None
        ///  
        /// </summary>
        public string ConnectionName
        {
            get { return this.connectionName; }
            set { this.connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this.connectionName != null;
        }

    }
}
    
