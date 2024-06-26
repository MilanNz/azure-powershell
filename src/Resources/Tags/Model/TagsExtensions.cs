﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Internal.Resources.Utilities;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Tags.Model
{
    public static class TagsExtensions
    {
        public static PSTag ToPSTag(this TagDetails tag)
        {
            return new PSTag()
            {
                Count = tag.Count.Value.ToString(),
                Name = tag.TagName,
                Values = tag.Values.Select(v => v.ToPSTagValue()).ToList(),
                ValuesTable = ConstructTagValuesTable(tag.Values.ToList())
            };
        }

        public static PSTagValue ToPSTagValue(this TagValue value)
        {
            return new PSTagValue()
            {
                Count = value.Count.Value.ToString(),
                Name = value.TagValueProperty
            };
        }

        /// <summary>
        /// Convert a SDK TagsResource object to PS PSTagResource
        /// </summary>
        /// <param name="tagsResource">SDK TagsResource extension method</param>
        /// <returns>PS object PSTagResource</returns>
        public static PSTagResource ToPSTagResource(this TagsResource tagsResource)
        {
            return new PSTagResource
            {
                Id = tagsResource?.Id,
                Name = tagsResource?.Name,
                Type = tagsResource?.Type,
                Properties = new PSTagsObject(tagsResource?.Properties?.TagsProperty),
                PropertiesTable = ResourcesExtensions.ConstructTagsTable(TagsConversionHelper.CreateTagHashtable(tagsResource?.Properties?.TagsProperty))
            };
        }

        private static TagValue EmptyTagValue
        {
            get
            {
                return new TagValue()
                {
                    TagValueProperty = string.Empty,
                    Count = new TagCount()
                    {
                        Type = string.Empty
                    }
                };
            }
        }

        private static string ConstructTagValuesTable(List<TagValue> tagValues)
        {
            StringBuilder tagValuesTable = new StringBuilder();

            if (tagValues.Count > 0)
            {
                int maxNameLength = Math.Max("Name".Length, tagValues.Where(v => v.TagValueProperty != null).DefaultIfEmpty(EmptyTagValue).Max(v => v.TagValueProperty.Length));
                int maxCountLength = Math.Max("Count".Length, tagValues.Where(v => v.Count.Value != null).DefaultIfEmpty(EmptyTagValue).Max(v => v.Count.Value.ToString().Length));

                string rowFormat = "{0, -" + maxNameLength + "}  {1, -" + maxCountLength + "}\r\n";
                tagValuesTable.AppendLine();
                tagValuesTable.AppendFormat(rowFormat, "Name", "Count");
                tagValuesTable.AppendFormat(rowFormat,
                    GeneralUtilities.GenerateSeparator(maxNameLength, "="),
                    GeneralUtilities.GenerateSeparator(maxCountLength, "="));

                foreach (TagValue tagValue in tagValues)
                {
                    tagValuesTable.AppendFormat(rowFormat, tagValue.TagValueProperty, tagValue.Count.Value);
                }
            }

            return tagValuesTable.ToString();
        }
    }
}
