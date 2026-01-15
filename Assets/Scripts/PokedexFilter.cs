using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class PokedexFilter
{
    [SerializeField] bool[] isType;
    [SerializeField] bool[] isEggGroup;
    [SerializeField] bool[] isColor;
    [SerializeField] bool[] isShape;
    [SerializeField] bool[] isAvailableInGame;
    [SerializeField] bool[] isGeneration;

    [SerializeField] bool[] excludeType;
    [SerializeField] bool[] extras;
    [SerializeField] bool isFavorite;
}
