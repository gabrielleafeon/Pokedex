using TMPro;
using UnityEngine;

public class FilterColorButton : FilterButton
{
    [SerializeField] BodyColor color;

    private void Start()
    {
        TMP_Text text;
        text = GetComponentInChildren<TMP_Text>();
        if (text != null)
        {
            text.color = PokedexStyleManager.ReturnColorBasedOnBodyColor(color);
        }
    }

    public override void FilterPokemon()
    {
        pokedex.ColorOrder(color);
    }

    public BodyColor Color
    {
        get => color;
        private set
        {
            color = value;
        }
    }
}
