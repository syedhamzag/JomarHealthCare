namespace JomarHealthCare.Domain.Entities
{
    public  class ClientTaskBoard
    {
        public ClientTaskBoard()
        {
            AssignedTo = new HashSet<ClientTaskBoardAssignedTo>();
        }
        public int TaskBoardId { get; set; }
        public string TaskName { get; set; }
        public Guid ClientId { get; set; }
        public string TaskImage { get; set; }
        public string Attachment { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Note { get; set; }
        public int Priority { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public Guid CreatedBy { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ClientTaskBoardAssignedTo> AssignedTo { get; set; }
    }
}
