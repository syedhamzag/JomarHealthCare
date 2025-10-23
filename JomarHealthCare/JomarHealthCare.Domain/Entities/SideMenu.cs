namespace JomarHealthCare.Domain.Entities
{
    public class SideMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Icon { get; set; }
		public int? parentsId { get; set; }
		public bool IsActive { get; set; }
		public int Level { get; set; }
	}
}
