using StageManagment.Entities;

namespace StageManagment.Service
{
    public class ServiceProgramStage
    {
        private readonly DbContextStageManagment _context;

        public ServiceProgramStage(DbContextStageManagment context)
        {
            _context = context;
        }

        // todo: inline kommentare
        public List<ProgramStage> GetAllProgramStages()
        {
            return _context.ProgramStages.ToList();
        }

        public void AddProgramStage(ProgramStage programStage)
        {
            _context.ProgramStages.Add(programStage);
            _context.SaveChanges();
        }

        public void UpdateProgramStage(ProgramStage programStageToUpdate)
        {
            var programStage = FindProgramStageById(programStageToUpdate.ProgramStageId);

            if (programStage is not null)
            {
                programStage.ProgramStageId = programStageToUpdate.ProgramStageId;
                programStage.Name = programStageToUpdate.Name;
                programStage.DurationInMinutes = programStageToUpdate.DurationInMinutes;
                programStage.PriceInEuro = programStageToUpdate.PriceInEuro;
                programStage.StartPriceInEuro = programStageToUpdate.StartPriceInEuro;
                programStage.EndPriceInEuro = programStageToUpdate.EndPriceInEuro;
                programStage.IsPayd = programStageToUpdate.IsPayd;
                programStage.ArtistId = programStageToUpdate.ArtistId;

                _context.SaveChanges();
            }
        }

        public void DeleteProgramStageById(int id)
        {
            _context.ProgramStages.Remove(FindProgramStageById(id));
            _context.SaveChanges();
        }

        public ProgramStage FindProgramStageById(int id)
        {
            return _context.ProgramStages.Find(id);
        }

        public bool CheckForDuplicateProgramStage(ProgramStage programStage)
        {
            return _context.ProgramStages.Any(p => p.Name == programStage.Name && p.DurationInMinutes == programStage.DurationInMinutes && p.PriceInEuro == programStage.PriceInEuro && p.ArtistId == programStage.ArtistId);
        }
    }
}
