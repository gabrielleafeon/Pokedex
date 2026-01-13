using UnityEngine;

public static class PokedexStyleManager
{
    public static Color ReturnColorBasedOnType(Pokemon pokemon)
    {
        Color color;

        if(pokemon.Type[0] == Types.Normal)
        {
            color = new Color(168, 167, 122);
            return color;
        }
        else if (pokemon.Type[0] == Types.Fighting)
        {
            color = new Color(194, 46, 40);
            return color;
        }
        else if (pokemon.Type[0] == Types.Flying)
        {
            color = new Color(169, 143, 243);
            return color;
        }
        else if (pokemon.Type[0] == Types.Poison)
        {
            color = new Color(163, 62, 161);
            return color;
        }
        else if (pokemon.Type[0] == Types.Ground)
        {
            color = new Color(226, 191, 101);
            return color;
        }
        else if (pokemon.Type[0] == Types.Rock)
        {
            color = new Color(182, 161, 54);
            return color;
        }
        else if (pokemon.Type[0] == Types.Bug)
        {
            color = new Color(166, 185, 26);
            return color;
        }
        else if (pokemon.Type[0] == Types.Ghost)
        {
            color = new Color(115, 87, 151);
            return color;
        }
        else if (pokemon.Type[0] == Types.Steel)
        {
            color = new Color(183, 183, 206);
            return color;
        }
        else if (pokemon.Type[0] == Types.Fire)
        {
            color = new Color(238, 129, 48);
            return color;
        }
        else if (pokemon.Type[0] == Types.Water)
        {
            color = new Color(99, 144, 240);
            return color;
        }
        else if (pokemon.Type[0] == Types.Grass)
        {
            color = new Color(122f/255, 199f/255, 76f/255);
            return color;
        }
        else if (pokemon.Type[0] == Types.Electric)
        {
            color = new Color(247, 208, 44);
            return color;
        }
        else if (pokemon.Type[0] == Types.Psychic)
        {
            color = new Color(249, 85, 135);
            return color;
        }
        else if (pokemon.Type[0] == Types.Ice)
        {
            color = new Color(150, 217, 214);
            return color;
        }
        else if (pokemon.Type[0] == Types.Dragon)
        {
            color = new Color(111, 53, 252);
            return color;
        }
        else if (pokemon.Type[0] == Types.Dark)
        {
            color = new Color(112, 87, 70);
            return color;
        }
        else if (pokemon.Type[0] == Types.Fairy)
        {
            color = new Color(214, 133, 173);
            return color;
        }
        else if (pokemon.Type[0] == Types.Stellar)
        {
            color = new Color(64, 181, 165);
            return color;
        }
        else
        {
            Debug.Log("No valid pokémon type");
            return new Color(0, 0, 0);
        }
    }
}
