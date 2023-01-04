using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCapa.Models
{
    public class HorizontalViewModel
    {       

        public string AuditNumber { get; set; }
        public string ProblemDescription { get; set; }
        public string CapaNumber { get; set; }
        public string Symptom { get; set; }
        public IEnumerable<GeneralInformation> MasterList { get; set; }
        public IEnumerable<Dthree> ContainmentActions { get; set; }
        public IEnumerable<DfiveActions> PermanentActions { get; set; }
        public DateTime ClosedDate { get; set; }
       
        //public async Task<IEnumerable<GeneralInformation>> GetCActions()
        //{
        //    var masterList = await db.GeneralInformation.Where(x => x.IsDeleted == false)
        //        .Include(x => x.Dthree)
        //        .Include(s => s.Dfive)
        //        .ThenInclude(a => a.DfiveActions)
        //        .ToListAsync();
        //    foreach(var item in masterList)
        //    {
        //        ContainmentActions = await db.Dthree.Where(x => x.GeneralInformartionId == item.GeneralInformartionId).ToListAsync();
        //        PermanentActions = await db.DfiveActions.Where(x => x.IsDeleted == false && x.GeneralInformartionId == item.GeneralInformartionId).ToListAsync();                
        //    }
            
        //    return masterList;            
        //}
    }
}
