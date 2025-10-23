namespace JomarHealthCare.Domain.Entities
{
    public class StaffTrainingMatrix
    {
        public StaffTrainingMatrix()
        {
            StaffTrainingMatrixList = new HashSet<StaffTrainingMatrixList>();
        }
        public int MatrixId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public ICollection<StaffTrainingMatrixList> StaffTrainingMatrixList { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }

    }
}
