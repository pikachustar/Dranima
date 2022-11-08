using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fakemon", menuName = "Fakemon/Create new Fakemon")]
public class FakemonBase : ScriptableObject
{

    [SerializeField] string _name;
    [TextArea]
    [SerializeField] string description;

    //Sprites
    [SerializeField] public Sprite frontSprite;
    [SerializeField] public Sprite backSprite;
    
    [SerializeField] types type1;
    [SerializeField] types type2;

    //Base Stats
    [SerializeField] public int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefence;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;
    

    public string Name {
        get { return _name;}
    }
    public string Desc {
        get { return description; }
    }
    public int MaxHP {
        get{return maxHP;}
    }
        public int Attack {
        get{ return attack;}
    }
        public int Defense {
        get{ return defense;}
    }
        public int SpAttack {
        get{ return spAttack;}
    }
        public int SpDefence {
        get{ return spDefence;}
    }
        public int Speed {
        get{ return speed;}
    }
    public types Type1 {
        get{ return type1;}
    }

    public types Type2 {
        get{ return type1;}
    }

    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }

}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] public MoveBase moveBase;
    [SerializeField] public int level;
}

public enum types
{
    None,
    Normal,
    Fire,
    Water,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon

}
