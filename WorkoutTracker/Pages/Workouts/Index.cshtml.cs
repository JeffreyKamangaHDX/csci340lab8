using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Data;
using WorkoutTracker.Models;

namespace WorkoutTracker.Pages_Workouts
{
    public class IndexModel : PageModel
    {
        private readonly WorkoutTracker.Data.WorkoutContext _context;

        public IndexModel(WorkoutTracker.Data.WorkoutContext context)
        {
            _context = context;
        }

        public IList<Workout> Workout { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Workout = await _context.Workout.ToListAsync();
        }
    }
}
