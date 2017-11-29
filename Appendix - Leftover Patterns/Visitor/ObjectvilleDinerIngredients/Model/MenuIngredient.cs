using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectvilleDinerIngredients.Model
{
    public class MenuIngredient : IIngredient, IElement
    {
        private string _ingredientName;
        public string IngredientName { get { return _ingredientName; } set {; } }

        private HealthRating _healthRating;
        public HealthRating HealthRating { get { return _healthRating; } private set {; } }


        public int Calories { get; }
        private int _protein;
        public int Protein { get { return _protein; } private set {; } }

        private int _carbs;
        public int Carbs { get { return _carbs; } private set {; } }

        public MenuIngredient(string name, HealthRating healthRating, int calories, int protein, int carbs)
        {
            _ingredientName = name;
            _healthRating = healthRating;
            this.Calories = calories;
            _protein = protein;
            _carbs = carbs;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitIngredients(this);
        }
    }
}
