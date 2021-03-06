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
    using ThirdParty.Json.LitJson;
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PipelineDescriptionUnmarshaller
      /// </summary>
      internal class PipelineDescriptionUnmarshaller : IUnmarshaller<PipelineDescription, XmlUnmarshallerContext>, IUnmarshaller<PipelineDescription, JsonUnmarshallerContext>
      {
        PipelineDescription IUnmarshaller<PipelineDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PipelineDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            PipelineDescription pipelineDescription = new PipelineDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("pipelineId", targetDepth))
              {
                context.Read();
                pipelineDescription.PipelineId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("name", targetDepth))
              {
                context.Read();
                pipelineDescription.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("fields", targetDepth))
              {
                context.Read();
                pipelineDescription.Fields = new List<Field>();
                        FieldUnmarshaller unmarshaller = FieldUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   pipelineDescription.Fields.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("description", targetDepth))
              {
                context.Read();
                pipelineDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return pipelineDescription;
                }
            }
          

            return pipelineDescription;
        }

        private static PipelineDescriptionUnmarshaller instance;
        public static PipelineDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PipelineDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
