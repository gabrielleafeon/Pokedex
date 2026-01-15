using System.Drawing;
using TMPro;
using UnityEngine;

public class FilterTypeButton : FilterButton
{
    [SerializeField] Types type;

    private void Start()
    {
        TMP_Text text;
        text = GetComponentInChildren<TMP_Text>();
        if (text != null)
        {
            text.color = PokedexStyleManager.ReturnColorBasedOnType(type);
        }
    }

    public override void FilterPokemon()
    {
        pokedex.TypeOrder(type);
    }

    public Types Type
    {
        get => type;
        private set
        {
            type = value;
        }
    }
}
