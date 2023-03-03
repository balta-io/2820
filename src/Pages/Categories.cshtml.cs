using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();

    public void OnGet(
        int skip = 0,
        int take = 25)
    {
        var temp = new List<Category>();

        for (var i = 0; i <= 1787; i++)
        {
            temp.Add(
                new Category(i,
                    $"Categoria {i}",
                    i * 18.95M));
        }

        CategoryList = temp
            .Skip(skip)
            .Take(take)
            .ToList();
    }
}

public record Category(
    int Id,
    string Title,
    decimal Price);