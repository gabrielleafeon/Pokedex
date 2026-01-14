using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FilterButton : MonoBehaviour
{
    [SerializeField] Pokedex pokedex;
    [SerializeField] Types type;
    [SerializeField] Shapes shape;

    private void Start()
    {
        TMP_Text text;
        text = GetComponentInChildren<TMP_Text>(); 
        if(text != null)
        {
            text.color = PokedexStyleManager.ReturnColorBasedOnType(type);
        }       
    }

    public void filterPokemonnType()
    {
        pokedex.TypeOrder(type);
    }

    //public void filterPokemonnShape()
    //{
    //    pokedex.ShapeOrder(shape);
    //}

    public Types Type
    {
        get => type;
        private set
        {
            type = value;
        }
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
