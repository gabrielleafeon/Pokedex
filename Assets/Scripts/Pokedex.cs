using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Pokedex : MonoBehaviour
{
    [SerializeField] Transform viewportContent;
    [SerializeField] PokedexMon pokedexPrefab;
    [SerializeField] Pokemon[] pokemonList;

    List<PokedexMon> currentPokemon;

    void Start()
    {
        currentPokemon = new List<PokedexMon>();
        pokemonList = Resources.LoadAll<Pokemon>("Pokemon");       
    }

    public void NationalDexOrder()
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            GeneratePokemon(pkmn);
        }
    }    

    public void TypeOrder(Types type)
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            if ((pkmn.Type[0] == type) || (pkmn.Type[1] == type))
            {
                GeneratePokemon(pkmn);
            }          
        }
    }

    public void ColorOrder(BodyColor bodyColor)
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            if (pkmn.BodyColor == bodyColor)
            {
                GeneratePokemon(pkmn);
            }
        }
    }

    public void ShapeOrder(Shapes shape)
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            if(pkmn.PokemonShape == shape)
            {
                GeneratePokemon(pkmn);
            }
        }
    }

    private void GeneratePokemon(Pokemon pokemon)
    {
        pokedexPrefab.SetPokemon(pokemon);
        PokedexMon pkmn = Instantiate(pokedexPrefab);
        pkmn.transform.SetParent(viewportContent);
        currentPokemon.Add(pkmn);
    }

    public void RemoveAllPokemon()
    {
        foreach(PokedexMon pkmn in currentPokemon)
        {           
            Destroy(pkmn.gameObject);
        }
        currentPokemon.Clear();
    }

}
