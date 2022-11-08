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
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;
    
    [SerializeField] types type1;
    [SerializeField] types type2;

    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefence;
    [SerializeField] int speed;
    

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



}
//ADD MISSING TYPES TODO... *****
public enum types
{
    None,
    Normal,
    Fire,
    Water,
    Grass,

}
