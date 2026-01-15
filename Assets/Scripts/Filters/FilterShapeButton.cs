using UnityEngine;

public class FilterShapeButton : FilterButton
{
    [SerializeField] Shapes shape;

    public override void FilterPokemon()
    {
        pokedex.ShapeOrder(shape);
    }

    public Shapes Shape
    {
        get => shape;
        private set
        {
            shape = value;
        }
    }
}
