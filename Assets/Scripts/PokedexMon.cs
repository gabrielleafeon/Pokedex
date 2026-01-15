using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokedexMon : MonoBehaviour
{
    [SerializeField] Pokemon pokemon;
    [SerializeField] Image backgroundBorder1;
    [SerializeField] Image backgroundBorder2;
    [SerializeField] Image pokemonImage;
    [SerializeField] TMP_Text pokemonName;
    [SerializeField] TMP_Text pokemonNumber;

    void Start()
    {
        if(pokemon == null)
        {
            Debug.Log("No pokémon set");
        }      
    }

    public void SetPokemon(Pokemon pokemon)
    {
        this.pokemon = pokemon;
        Color[] colors = PokedexStyleManager.ReturnColorBasedOnPokemonType(pokemon);
        backgroundBorder1.color = colors[0];
        backgroundBorder2.color = colors[1];
        pokemonImage.sprite = pokemon.Sprite;
        pokemonName.text = pokemon.PokemonName;
        pokemonNumber.text = pokemon.PokedexNumber.ToString("D4");
    }

    public PokedexMon(Pokemon pokemon)
    {
        SetPokemon(pokemon);
    }
}
