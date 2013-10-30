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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RespondActivityTaskFailed operation.
    /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> has failed with <c>reason</c> (if
    /// specified). The <c>reason</c> and <c>details</c> appear in the <c>ActivityTaskFailed</c> event added to the workflow history. </para> <para>
    /// A task is considered open from the time that it is scheduled until it is closed. Therefore a task is reported as open while a worker is
    /// processing it. A task is closed after it has been specified in a call to RespondActivityTaskCompleted, RespondActivityTaskCanceled,
    /// RespondActivityTaskFailed, or the task has timed out. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control
    /// this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.RespondActivityTaskFailed"/>
    public class RespondActivityTaskFailedRequest : AmazonWebServiceRequest
    {
        private string taskToken;
        private string reason;
        private string details;

        /// <summary>
        /// The <c>taskToken</c> of the <a>ActivityTask</a>. <important> The <c>taskToken</c> is generated by the service and should be treated as an
        /// opaque value. If the task is passed to another process, its <c>taskToken</c> must also be passed. This enables it to provide its progress
        /// and respond with results. </important>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TaskToken
        {
            get { return this.taskToken; }
            set { this.taskToken = value; }
        }

        /// <summary>
        /// Sets the TaskToken property
        /// </summary>
        /// <param name="taskToken">The value to set for the TaskToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RespondActivityTaskFailedRequest WithTaskToken(string taskToken)
        {
            this.taskToken = taskToken;
            return this;
        }
            

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this.taskToken != null;
        }

        /// <summary>
        /// Description of the error that may assist in diagnostics.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        /// <summary>
        /// Sets the Reason property
        /// </summary>
        /// <param name="reason">The value to set for the Reason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RespondActivityTaskFailedRequest WithReason(string reason)
        {
            this.reason = reason;
            return this;
        }
            

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this.reason != null;
        }

        /// <summary>
        /// Optional detailed information about the failure.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        /// <summary>
        /// Sets the Details property
        /// </summary>
        /// <param name="details">The value to set for the Details property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RespondActivityTaskFailedRequest WithDetails(string details)
        {
            this.details = details;
            return this;
        }
            

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this.details != null;
        }
    }
}
    
