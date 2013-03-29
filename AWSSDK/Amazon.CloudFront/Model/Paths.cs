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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that contains information about the objects that you want to invalidate. </para>
    /// </summary>
    public class Paths  
    {
        
        private int? quantity;
        private List<string> items = new List<string>();

        /// <summary>
        /// The number of objects that you want to invalidate.
        ///  
        /// </summary>
        public int Quantity
        {
            get { return this.quantity ?? default(int); }
            set { this.quantity = value; }
        }

        /// <summary>
        /// Sets the Quantity property
        /// </summary>
        /// <param name="quantity">The value to set for the Quantity property </param>
        /// <returns>this instance</returns>
        public Paths WithQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }
            

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this.quantity.HasValue;       
        }

        /// <summary>
        /// A complex type that contains a list of the objects that you want to invalidate.
        ///  
        /// </summary>
        public List<string> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        public Paths WithItems(params string[] items)
        {
            foreach (string element in items)
            {
                this.items.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        public Paths WithItems(IEnumerable<string> items)
        {
            foreach (string element in items)
            {
                this.items.Add(element);
            }

            return this;
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;       
        }
    }
}
