/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Instance block device mapping parameter.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceBlockDeviceMappingParameter
    {    
        private string deviceNameField;
        private string virtualNameField;
        private InstanceEbsBlockDeviceParameter ebsField;
        private string noDeviceField;

        /// <summary>
        /// The device name exposed to the instance (e.g., /dev/sdh).
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceName")]
        public string DeviceName
        {
            get { return this.deviceNameField; }
            set { this.deviceNameField = value; }
        }

        /// <summary>
        /// Sets the device name exposed to the instance (e.g., /dev/sdh).
        /// </summary>
        /// <param name="deviceName">The device name (e.g., /dev/sdh).</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMappingParameter WithDeviceName(string deviceName)
        {
            this.deviceNameField = deviceName;
            return this;
        }

        /// <summary>
        /// Checks if DeviceName property is set
        /// </summary>
        /// <returns>true if DeviceName property is set</returns>
        public bool IsSetDeviceName()
        {
            return this.deviceNameField != null;
        }

        /// <summary>
        /// The virtual device name.
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualName")]
        public string VirtualName
        {
            get { return this.virtualNameField; }
            set { this.virtualNameField = value; }
        }

        /// <summary>
        /// Sets the virtual device name.
        /// </summary>
        /// <param name="virtualName">The virtual device name.</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMappingParameter WithVirtualName(string virtualName)
        {
            this.virtualNameField = virtualName;
            return this;
        }

        /// <summary>
        /// Checks if VirtualName property is set
        /// </summary>
        /// <returns>true if VirtualName property is set</returns>
        public bool IsSetVirtualName()
        {
            return this.virtualNameField != null;
        }

        /// <summary>
        /// Parameters used to automatically setup Amazon EBS volumes
        /// when the instance is launched.
        /// </summary>
        [XmlElementAttribute(ElementName = "Ebs")]
        public InstanceEbsBlockDeviceParameter Ebs
        {
            get { return this.ebsField; }
            set { this.ebsField = value; }
        }

        /// <summary>
        /// Sets parameters used to automatically setup Amazon EBS volumes
        /// when the instance is launched.
        /// </summary>
        /// <param name="ebs">Specifies parameters used to automatically
        /// setup Amazon EBS volumes when the instance is launched.</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMappingParameter WithEbs(InstanceEbsBlockDeviceParameter ebs)
        {
            this.ebsField = ebs;
            return this;
        }

        /// <summary>
        /// Checks if Ebs property is set
        /// </summary>
        /// <returns>true if Ebs property is set</returns>
        public bool IsSetEbs()
        {
            return this.ebsField != null;
        }

        /// <summary>
        /// The device name (e.g., /dev/sdb) to suppress during instance launch.
        /// </summary>
        [XmlElementAttribute(ElementName = "NoDevice")]
        public string NoDevice
        {
            get { return this.noDeviceField; }
            set { this.noDeviceField = value; }
        }

        /// <summary>
        /// Sets the device name (e.g., /dev/sdb) to suppress during instance launch.
        /// </summary>
        /// <param name="noDevice">Specifies the device name (e.g., /dev/sdb) to
        /// suppress during instance launch.</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMappingParameter WithNoDevice(string noDevice)
        {
            this.noDeviceField = noDevice;
            return this;
        }

        /// <summary>
        /// Checks if NoDevice property is set
        /// </summary>
        /// <returns>true if NoDevice property is set</returns>
        public bool IsSetNoDevice()
        {
            return this.noDeviceField != null;
        }

    }
}
