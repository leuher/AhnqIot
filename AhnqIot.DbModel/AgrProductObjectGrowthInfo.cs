#region Code File Comment

// SOLUTION   ： 农业气象物联网V3
// PROJECT    ： AhnqIot.DbModel
// FILENAME   ： AgrProductObjectGrowthInfo.cs
// AUTHOR     ： soft-cq
// CREATE TIME： 2016-01-11 15:27
// COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class AgrProductObjectGrowthInfo : BaseEntity
    {
        public AgrProductObjectGrowthInfo()
        {
            AgrDiagnosticModel = new HashSet<AgrDiagnosticModel>();
        }

        public string AgrProductObjectSerialnum { get; set; }
        public int DayCount { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AgrDiagnosticModel> AgrDiagnosticModel { get; set; }
        public virtual AgrProductObject AgrProductObjectSerialnumNavigation { get; set; }
    }
}