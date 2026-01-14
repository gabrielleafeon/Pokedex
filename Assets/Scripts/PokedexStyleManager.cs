using UnityEngine;

public static class PokedexStyleManager
{
    public static Color[] ReturnColorBasedOnPokemon(Pokemon pokemon)
    {
        Color[] colors = new Color[2];
        colors[0] = ReturnColorBasedOnType(pokemon.Type[0]);
        colors[1] = ReturnColorBasedOnType(pokemon.Type[1]);
        return colors;
    }

    public static Color ReturnColorBasedOnType(Types type)
    {
        Color color;

        if (type == Types.Normal)
        {
            color = new Color(168f / 255, 167f / 255, 122f / 255);
            return color;
        }
        else if (type == Types.Fighting)
        {
            color = new Color(194f / 255, 46f / 255, 40f / 255);
            return color;
        }
        else if (type == Types.Flying)
        {
            color = new Color(169f / 255, 143f / 255, 243f / 255);
            return color;
        }
        else if (type == Types.Poison)
        {
            color = new Color(163f / 255, 62f / 255, 161f / 255);
            return color;
        }
        else if (type == Types.Ground)
        {
            color = new Color(226f / 255, 191f / 255, 101f / 255);
            return color;
        }
        else if (type == Types.Rock)
        {
            color = new Color(182f / 255, 161f / 255, 54f / 255);
            return color;
        }
        else if (type == Types.Bug)
        {
            color = new Color(166f / 255, 185f / 255, 26f / 255);
            return color;
        }
        else if (type == Types.Ghost)
        {
            color = new Color(115f / 255, 87f / 255, 151f / 255);
            return color;
        }
        else if (type == Types.Steel)
        {
            color = new Color(183f / 255, 183f / 255, 206f / 255);
            return color;
        }
        else if (type == Types.Fire)
        {
            color = new Color(238f / 255, 129f / 255, 48f / 255);
            return color;
        }
        else if (type == Types.Water)
        {
            color = new Color(99f / 255, 144f / 255, 240f / 255);
            return color;
        }
        else if (type == Types.Grass)
        {
            color = new Color(122f / 255, 199f / 255, 76f / 255);
            return color;
        }
        else if (type == Types.Electric)
        {
            color = new Color(247f / 255, 208f / 255, 44f / 255);
            return color;
        }
        else if (type == Types.Psychic)
        {
            color = new Color(249f / 255, 85f / 255, 135f / 255);
            return color;
        }
        else if (type == Types.Ice)
        {
            color = new Color(150f / 255, 217f / 255, 214f / 255);
            return color;
        }
        else if (type == Types.Dragon)
        {
            color = new Color(111f / 255, 53f / 255, 252f / 255);
            return color;
        }
        else if (type == Types.Dark)
        {
            color = new Color(112f / 255, 87f / 255, 70f / 255);
            return color;
        }
        else if (type == Types.Fairy)
        {
            color = new Color(214f / 255, 133f / 255, 173f / 255);
            return color;
        }
        else if (type == Types.Stellar)
        {
            color = new Color(64f / 255, 181f / 255, 165f / 255);
            return color;
        }
        else
        {
            Debug.Log("No valid pokémon type");
            return new Color(0, 0, 0);
        }
    }
}
