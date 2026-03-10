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
    public class DetailsModel : PageModel
    {
        private readonly WorkoutTracker.Data.WorkoutContext _context;

        public DetailsModel(WorkoutTracker.Data.WorkoutContext context)
        {
            _context = context;
        }

        public Workout Workout { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workout = await _context.Workout.FirstOrDefaultAsync(m => m.Id == id);

            if (workout is not null)
            {
                Workout = workout;

                return Page();
            }

            return NotFound();
        }
    }
}
