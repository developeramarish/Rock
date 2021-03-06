//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Used with POST to ~/api/Attendances/Import
    /// </summary>
    public partial class AttendanceImportEntity
    {
        /// <summary />
        public int? GroupId { get; set; }

        /// <summary />
        public int? LocationId { get; set; }

        /// <summary />
        public DateTime OccurrenceDate { get; set; }

        /// <summary />
        public int? PersonAliasId { get; set; }

        /// <summary />
        public int? PersonId { get; set; }

        /// <summary />
        public int? ScheduleId { get; set; }

        /// <summary />
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Copies the base properties from a source AttendanceImport object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AttendanceImport source )
        {
            this.GroupId = source.GroupId;
            this.LocationId = source.LocationId;
            this.OccurrenceDate = source.OccurrenceDate;
            this.PersonAliasId = source.PersonAliasId;
            this.PersonId = source.PersonId;
            this.ScheduleId = source.ScheduleId;
            this.StartDateTime = source.StartDateTime;

        }
    }

    /// <summary>
    /// Used with POST to ~/api/Attendances/Import
    /// </summary>
    public partial class AttendanceImport : AttendanceImportEntity
    {
    }
}
