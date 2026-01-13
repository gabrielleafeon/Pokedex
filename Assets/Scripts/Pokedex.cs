using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Pokedex : MonoBehaviour
{
    [SerializeField] Transform viewportContent;
    [SerializeField] PokedexMon pokedexPrefab;
    [SerializeField] Pokemon[] pokemonList;

    void Start()
    {
        pokemonList = Resources.LoadAll<Pokemon>("Pokemon");       
    }

    public void NationalDexOrder()
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            pokedexPrefab.SetPokemon(pkmn);
            PokedexMon pokedex = Instantiate(pokedexPrefab);
            pokedex.transform.SetParent(viewportContent);
        }
    }

    public void TypeOrder(int type)
    {
        foreach (Pokemon pkmn in pokemonList)
        {
            if (((int)pkmn.Type[0] == type) || ((int)pkmn.Type[1] == type))
            {
                pokedexPrefab.SetPokemon(pkmn);
                PokedexMon pokedex = Instantiate(pokedexPrefab);
                pokedex.transform.SetParent(viewportContent);
            }          
        }
    }
}
