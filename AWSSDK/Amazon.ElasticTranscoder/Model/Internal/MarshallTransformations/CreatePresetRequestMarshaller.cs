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

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Preset Request Marshaller
    /// </summary>       
    internal class CreatePresetRequestMarshaller : IMarshaller<IRequest, CreatePresetRequest> 
    {
        

        public IRequest Marshall(CreatePresetRequest createPresetRequest) 
        {

            IRequest request = new DefaultRequest(createPresetRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.CreatePreset";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "POST";
              
            string uriResourcePath = "2012-09-25/presets"; 
            
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
                
                if (createPresetRequest != null && createPresetRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(createPresetRequest.Name);
                }
                if (createPresetRequest != null && createPresetRequest.IsSetDescription()) 
                {
                    writer.WritePropertyName("Description");
                    writer.Write(createPresetRequest.Description);
                }
                if (createPresetRequest != null && createPresetRequest.IsSetContainer()) 
                {
                    writer.WritePropertyName("Container");
                    writer.Write(createPresetRequest.Container);
                }

                if (createPresetRequest != null) 
                {
                    VideoParameters video = createPresetRequest.Video;
                    if (video != null)
                    {
                        writer.WritePropertyName("Video");
                        writer.WriteObjectStart();
                        if (video != null && video.IsSetCodec()) 
                        {
                            writer.WritePropertyName("Codec");
                            writer.Write(video.Codec);
                        }
                        if (video != null) 
                        {
                            if (video.CodecOptions != null && video.CodecOptions.Count > 0)
                            {
                                writer.WritePropertyName("CodecOptions");
                                writer.WriteObjectStart();
                                foreach (string videoCodecOptionsKey in video.CodecOptions.Keys)
                                {
                                    string codecOptionsListValue;
                                    bool codecOptionsListValueHasValue = video.CodecOptions.TryGetValue(videoCodecOptionsKey, out codecOptionsListValue);
                                    writer.WritePropertyName(videoCodecOptionsKey);

                                writer.Write(codecOptionsListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (video != null && video.IsSetKeyframesMaxDist()) 
                        {
                            writer.WritePropertyName("KeyframesMaxDist");
                            writer.Write(video.KeyframesMaxDist);
                        }
                        if (video != null && video.IsSetFixedGOP()) 
                        {
                            writer.WritePropertyName("FixedGOP");
                            writer.Write(video.FixedGOP);
                        }
                        if (video != null && video.IsSetBitRate()) 
                        {
                            writer.WritePropertyName("BitRate");
                            writer.Write(video.BitRate);
                        }
                        if (video != null && video.IsSetFrameRate()) 
                        {
                            writer.WritePropertyName("FrameRate");
                            writer.Write(video.FrameRate);
                        }
                        if (video != null && video.IsSetResolution()) 
                        {
                            writer.WritePropertyName("Resolution");
                            writer.Write(video.Resolution);
                        }
                        if (video != null && video.IsSetAspectRatio()) 
                        {
                            writer.WritePropertyName("AspectRatio");
                            writer.Write(video.AspectRatio);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createPresetRequest != null) 
                {
                    AudioParameters audio = createPresetRequest.Audio;
                    if (audio != null)
                    {
                        writer.WritePropertyName("Audio");
                        writer.WriteObjectStart();
                        if (audio != null && audio.IsSetCodec()) 
                        {
                            writer.WritePropertyName("Codec");
                            writer.Write(audio.Codec);
                        }
                        if (audio != null && audio.IsSetSampleRate()) 
                        {
                            writer.WritePropertyName("SampleRate");
                            writer.Write(audio.SampleRate);
                        }
                        if (audio != null && audio.IsSetBitRate()) 
                        {
                            writer.WritePropertyName("BitRate");
                            writer.Write(audio.BitRate);
                        }
                        if (audio != null && audio.IsSetChannels()) 
                        {
                            writer.WritePropertyName("Channels");
                            writer.Write(audio.Channels);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createPresetRequest != null) 
                {
                    Thumbnails thumbnails = createPresetRequest.Thumbnails;
                    if (thumbnails != null)
                    {
                        writer.WritePropertyName("Thumbnails");
                        writer.WriteObjectStart();
                        if (thumbnails != null && thumbnails.IsSetFormat()) 
                        {
                            writer.WritePropertyName("Format");
                            writer.Write(thumbnails.Format);
                        }
                        if (thumbnails != null && thumbnails.IsSetInterval()) 
                        {
                            writer.WritePropertyName("Interval");
                            writer.Write(thumbnails.Interval);
                        }
                        if (thumbnails != null && thumbnails.IsSetResolution()) 
                        {
                            writer.WritePropertyName("Resolution");
                            writer.Write(thumbnails.Resolution);
                        }
                        if (thumbnails != null && thumbnails.IsSetAspectRatio()) 
                        {
                            writer.WritePropertyName("AspectRatio");
                            writer.Write(thumbnails.AspectRatio);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
