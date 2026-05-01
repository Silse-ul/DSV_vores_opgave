using dsv_mini.model;
using dsv_mini.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace dsv_mini.Pages;

public class CreateBooking : PageModel
{
    private IBookingSystemRepo _repo;

    public CreateBooking(IBookingSystemRepo repo)
    {
        _repo = repo;
    }

    [BindProperty]
    public Bookingsystem NewBooking { get; set; }

    public void OnGet(int roomId) 
    {
        NewBooking = new Bookingsystem();
        NewBooking.RoomId = roomId;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) 
            return Page();

        _repo.Add(NewBooking);

        TempData["SuccessMessage"] = $"Tillykke! Din booking af lokale {NewBooking.RoomId} er nu oprettet.";

        // Send user tilbage til oversigten eller detaljesiden efter succes
        return RedirectToPage("/CreateBooking", new { id = NewBooking.RoomId });
    }
    public void OnGet()
    {
        
    }
}