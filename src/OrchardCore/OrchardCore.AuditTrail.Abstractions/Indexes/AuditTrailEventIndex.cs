using System;
using YesSql.Indexes;

namespace OrchardCore.AuditTrail.Indexes
{
    /// <summary>
    /// Used to index the generic Audit Trail Events.
    /// </summary>
    public class AuditTrailEventIndex : MapIndex
    {
        public string EventId { get; set; }
        public string Category { get; set; }
        public string EventName { get; set; }
        public string CorrelationId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}