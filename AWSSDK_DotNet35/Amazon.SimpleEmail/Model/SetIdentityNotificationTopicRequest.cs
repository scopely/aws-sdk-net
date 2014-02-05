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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityNotificationTopic operation.
    /// <para>Given an identity (email address or domain), sets the Amazon SNS topic to which Amazon SES will publish bounce and complaint
    /// notifications for emails sent with that identity as the <c>Source</c> .
    /// Publishing to topics may only be disabled when feedback forwarding is enabled.</para> <para>This action is throttled at one request
    /// per second.</para> <para>For more information about feedback notification, see the <a
    /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/bounce-complaint-notifications.html" >Amazon SES Developer Guide</a> .</para>
    /// </summary>
    public partial class SetIdentityNotificationTopicRequest : AmazonSimpleEmailServiceRequest
    {
        private string identity;
        private NotificationType notificationType;
        private string snsTopic;


        /// <summary>
        /// The identity for which the topic will be set. Examples: <c>user@example.com</c>, <c>example.com</c>.
        ///  
        /// </summary>
        public string Identity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this.identity != null;
        }

        /// <summary>
        /// The type of feedback notifications that will be published to the specified topic.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Bounce, Complaint</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public NotificationType NotificationType
        {
            get { return this.notificationType; }
            set { this.notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this.notificationType != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (Amazon SNS) topic. If the parameter is omitted from the request or
        /// a null value is passed, the topic is cleared and publishing is disabled.
        ///  
        /// </summary>
        public string SnsTopic
        {
            get { return this.snsTopic; }
            set { this.snsTopic = value; }
        }

        // Check to see if SnsTopic property is set
        internal bool IsSetSnsTopic()
        {
            return this.snsTopic != null;
        }

    }
}
    
