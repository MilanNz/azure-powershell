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

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    using Microsoft.Azure.Management.CosmosDB.Models;

    public class PSCassandraKeyspaceGetResults 
    {
        public PSCassandraKeyspaceGetResults()
        {
        }        
        
        public PSCassandraKeyspaceGetResults(CassandraKeyspaceGetResults cassandraKeyspaceGetResults)
        {
            Name = cassandraKeyspaceGetResults.Name;
            Id = cassandraKeyspaceGetResults.Id;
            Resource = new PSCassandraKeyspaceGetPropertiesResource(cassandraKeyspaceGetResults.Resource);
        }

        /// <summary>
        /// Gets or sets Name of the Cosmos DB Cassandra keyspace
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets Id of the Cosmos DB Cassandra keyspace
        /// </summary>
        public string Id { get; set; }
        public PSCassandraKeyspaceGetPropertiesResource Resource { get; set; }
    }
}
