namespace AwesomeDevEventsApi.Entities
{
    public class DevEvent
    {
        #region "Properties"
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }
        #endregion "Properties"

        #region "Constructor"
        public DevEvent()
        {
            Speakers = new List<DevEventSpeaker>();
            IsDeleted = false;
        }
        #endregion "Constructor"

        #region "Methods"
        /// <summary>
        /// Infos to Update Event
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public void Update (string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
        /// <summary>
        /// Infos to Delete Event
        /// </summary>
        public void Delete()
        {
            IsDeleted = true;
        }
        #endregion "Methods"
    }
}
