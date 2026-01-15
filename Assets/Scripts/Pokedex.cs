using System;
using System.Collections.Generic;
using System.Linq;
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

        //List<Func<Pokemon, bool>> allFilter = new List<Func<Pokemon, bool>>();
        //Func<Pokemon, bool> filterFlying = (pkmn) => pkmn.Type[0] == Types.Flying;
        //Func<Pokemon, bool> filterFighting = (pkmn) => pkmn.Type[0] == Types.Fighting;        
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
