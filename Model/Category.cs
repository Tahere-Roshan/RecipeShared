namespace RecipeShared.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public List<Recipe>? Recipes { get; set; }
    }
}
