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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Defines a field in the index, including its name, type, and the source of its data. The <c>IndexFieldType</c> indicates which of the
    /// options will be present. It is invalid to specify options for a type other than the <c>IndexFieldType</c> .</para>
    /// </summary>
    public class IndexField
    {
        
        private string indexFieldName;
        private IndexFieldType indexFieldType;
        private UIntOptions uIntOptions;
        private LiteralOptions literalOptions;
        private TextOptions textOptions;
        private List<SourceAttribute> sourceAttributes = new List<SourceAttribute>();


        /// <summary>
        /// The name of a field in the search index. Field names must begin with a letter and can contain the following characters: a-z (lowercase),
        /// 0-9, and _ (underscore). Uppercase letters and hyphens are not allowed. The names "body", "docid", and "text_relevance" are reserved and
        /// cannot be specified as field or rank expression names.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IndexFieldName
        {
            get { return this.indexFieldName; }
            set { this.indexFieldName = value; }
        }

        // Check to see if IndexFieldName property is set
        internal bool IsSetIndexFieldName()
        {
            return this.indexFieldName != null;
        }

        /// <summary>
        /// The type of field. Based on this type, exactly one of the <a>UIntOptions</a>, <a>LiteralOptions</a> or <a>TextOptions</a> must be present.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>uint, literal, text</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public IndexFieldType IndexFieldType
        {
            get { return this.indexFieldType; }
            set { this.indexFieldType = value; }
        }

        // Check to see if IndexFieldType property is set
        internal bool IsSetIndexFieldType()
        {
            return this.indexFieldType != null;
        }

        /// <summary>
        /// Options for an unsigned integer field. Present if <c>IndexFieldType</c> specifies the field is of type unsigned integer.
        ///  
        /// </summary>
        public UIntOptions UIntOptions
        {
            get { return this.uIntOptions; }
            set { this.uIntOptions = value; }
        }

        // Check to see if UIntOptions property is set
        internal bool IsSetUIntOptions()
        {
            return this.uIntOptions != null;
        }

        /// <summary>
        /// Options for literal field. Present if <c>IndexFieldType</c> specifies the field is of type literal.
        ///  
        /// </summary>
        public LiteralOptions LiteralOptions
        {
            get { return this.literalOptions; }
            set { this.literalOptions = value; }
        }

        // Check to see if LiteralOptions property is set
        internal bool IsSetLiteralOptions()
        {
            return this.literalOptions != null;
        }

        /// <summary>
        /// Options for text field. Present if <c>IndexFieldType</c> specifies the field is of type text.
        ///  
        /// </summary>
        public TextOptions TextOptions
        {
            get { return this.textOptions; }
            set { this.textOptions = value; }
        }

        // Check to see if TextOptions property is set
        internal bool IsSetTextOptions()
        {
            return this.textOptions != null;
        }

        /// <summary>
        /// An optional list of source attributes that provide data for this index field. If not specified, the data is pulled from a source attribute
        /// with the same name as this <c>IndexField</c>. When one or more source attributes are specified, an optional data transformation can be
        /// applied to the source data when populating the index field. You can configure a maximum of 20 sources for an <c>IndexField</c>.
        ///  
        /// </summary>
        public List<SourceAttribute> SourceAttributes
        {
            get { return this.sourceAttributes; }
            set { this.sourceAttributes = value; }
        }

        // Check to see if SourceAttributes property is set
        internal bool IsSetSourceAttributes()
        {
            return this.sourceAttributes.Count > 0;
        }
    }
}
