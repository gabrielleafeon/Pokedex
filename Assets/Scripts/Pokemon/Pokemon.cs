using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokémon/Create New Pokémon")]
public class Pokemon : ScriptableObject
{
    [SerializeField] string pokemonName;
    [SerializeField] int pokedexNumber;
    [SerializeField] int form;
    [SerializeField] int[] stats = new int[6]; //Order: HP Atk Def Sp.Atk Sp.Def Speed
    [SerializeField] Types[] types = new Types[2];
    [SerializeField] int catchRate;
    [SerializeField] int baseExp;
    [SerializeField] int[] evYield = new int[6]; //Order: HP Atk Def Sp.Atk Sp.Def Speed
    [SerializeField] float genderRatio;
    [SerializeField] int eggCycles;
    [SerializeField] int baseFriendship;
    [SerializeField] GrowthRate growthRate;
    [SerializeField] EggGroups[] eggGroups = new EggGroups[2];
    [SerializeField] Abilities[] abilities = new Abilities[3];
    [SerializeField] BodyColor bodyColor;
    [SerializeField] string dexEntry;
    [SerializeField] string species;
    [SerializeField] float height;
    [SerializeField] float weight;

    [Space(20)]
    [SerializeField] GameAvailability gameAvailability;

    public string PokemonName
    {
        get => pokemonName;
        private set
        {
            pokemonName = value;
        }
    }

    public int PokedexNumber
    {
        get => pokedexNumber;
        private set
        {
            pokedexNumber = value;
        }
    }

    public int Form
    {
        get => form;
        private set
        {
            form = value;
        }
    }

    public int[] Stats
    {
        get => stats;
        private set
        {
            stats = value;
        }
    }

    public Types[] Type
    {
        get => types;
        private set
        {
            types = value;
        }
    }

    public int CatchRate 
    { 
        get => catchRate; 
        private set
        {
            catchRate = value;
        }
    }

    public int BaseExp
    {
        get => baseExp;
        private set
        {
            baseExp = value;
        }
    }

    public int[] EVYield
    {
        get => evYield;
        private set
        {
            evYield = value;
        }
    }

    public float GenderRatio
    {
        get => genderRatio;
        private set
        {
            genderRatio = value;
        }
    }

    public int EggCycles
    {
        get => eggCycles;
        private set
        {
            eggCycles = value;
        }
    }

    public int BaseFriendship
    {
        get => baseFriendship;
        private set
        {
            baseFriendship = value;
        }
    }
    public GrowthRate GrowthRate
    {
        get => growthRate;
        private set
        {
            growthRate = value;
        }
    }

    public EggGroups[] EggGroups
    {
        get => eggGroups;
        private set
        {
            eggGroups = value;
        }
    }

    public Abilities[] Abilities
    {
        get => abilities;
        private set
        {
            abilities = value;
        }
    }

    public BodyColor BodyColor
    {
        get => bodyColor;
        private set
        {
            bodyColor = value;
        }
    }

    public string DexEntries
    {
        get => dexEntry;
        private set
        {
            dexEntry = value;
        }
    }

    public string Species
    {
        get => species;
        private set
        {
            species = value;
        }
    }

    public float Height
    {
        get => height;
        private set
        {
            height = value;
        }
    }

    public float Weight
    {
        get => weight;
        private set
        {
            weight = value;
        }
    }

    public GameAvailability GameAvailability
    {
        get => gameAvailability;
        private set
        {
            gameAvailability = value;
        }
    }
}
