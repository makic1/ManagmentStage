using StageManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagment.Service
{
    public class ServicePerformance
    {
        private readonly DbContextStageManagment _context;

        public ServicePerformance(DbContextStageManagment context)
        {
            _context = context;
        }

        /// <summary>
        /// Get All performances
        /// </summary>
        /// <returns>a list of all performances</returns>
        public List<Performance> GetAllPerformances()
        {
            return _context.Performances.ToList();
        }

        /// <summary>
        /// Get All activ performances
        /// </summary>
        /// <returns>a list of all activ performances</returns>
        public List<Performance> GetAllActivPerformance()
        {
            return _context.Performances.Where(x => x.IsActive).ToList();
        }

        /// <summary>
        /// Add a performance
        /// </summary>
        /// <param name="performance"></param>
        public void AddPerformance(Performance performance)
        {
            _context.Performances.Add(performance);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update a performance
        /// </summary>
        /// <param name="performanceToUpdate"></param>
        public void UpdatePerformance(Performance performanceToUpdate)
        {
            var performance = FindPerformanceById(performanceToUpdate.PerformanceId);

            if (performance is not null)
            {
                performance.PerformanceId = performanceToUpdate.PerformanceId;
                performance.Name = performanceToUpdate.Name;
                performance.StartPerformance = performanceToUpdate.StartPerformance;
                performance.EndPerformance = performanceToUpdate.EndPerformance;
                performance.IsActive = performanceToUpdate.IsActive;
                performance.ProgramStageId = performanceToUpdate.ProgramStageId;

                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a performance by id
        /// </summary>
        /// <param name="id"></param>
        public void DeletePerformanceById(int id)
        {
            _context.Performances.Remove(FindPerformanceById(id));
            _context.SaveChanges();
        }

        /// <summary>
        /// Find a performance by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a Performance</returns>
        public Performance FindPerformanceById(int id)
        {
            return _context.Performances.Find(id);
        }

        /// <summary>
        /// Check for dulicate perfromance
        /// </summary>
        /// <param name="performance"></param>
        /// <returns>true or false</returns>
        public bool CheckForDuplicatePerformance(Performance performance)
        {
            return _context.Performances.Any(p => p.Name == performance.Name && p.StartPerformance == performance.EndPerformance && p.EndPerformance == p.EndPerformance && p.ProgramStageId == performance.ProgramStageId);
        }
    }
}
