namespace EventBus.Messages.Events
{
    public class IntegrationBaseEvent
    {
        public IntegrationBaseEvent()
        {
            // JST Zone
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo jstZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            
            Id = Guid.NewGuid();
            // JST (UTC+9)
            CreationDate = TimeZoneInfo.ConvertTimeFromUtc(utcNow, jstZone);
        }

        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            Id=id;
            CreationDate=creationDate;
        }

        public Guid Id { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}
