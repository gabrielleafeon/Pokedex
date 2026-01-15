using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class FilterButton : MonoBehaviour
{
    [SerializeField] protected Pokedex pokedex;    

    public abstract void FilterPokemon();
    //public abstract Func<Pokemon, bool> FilterPokemonFunc();

    public Pokedex Pokedex
    {
        get => pokedex;
        private set
        {
            pokedex = value;
        }
    }
}
