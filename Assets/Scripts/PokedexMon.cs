using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokedexMon : MonoBehaviour
{
    [SerializeField] Pokemon pokemon;
    [SerializeField] Image background;
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
        background.color = PokedexStyleManager.ReturnColorBasedOnType(pokemon);
        pokemonImage.sprite = pokemon.Sprite;
        pokemonName.text = pokemon.PokemonName;
        pokemonNumber.text = pokemon.PokedexNumber.ToString("D4");
    }

    public PokedexMon(Pokemon pokemon)
    {
        SetPokemon(pokemon);
    }
}
