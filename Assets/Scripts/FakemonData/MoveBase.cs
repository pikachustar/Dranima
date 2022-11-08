using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Fakemon/ Create new move")]
public class MoveBase : ScriptableObject
{

    [SerializeField] string _name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] types type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
    [SerializeField] properties property;

    //Returns move properties
    public string Name {
        get{return _name;}
    }
    public string Desc {
        get{return description;}
    }
    public int Power {
        get{ return power;}
    }
    public int Accuracy {
        get{return accuracy;}
    }
    public int PP {
        get{return pp;}
    }
    public properties Prop {
        get{return property;}
    }


    public enum properties {
        Physical,
        Special,
        Buff,
        Debuff,
        Status
    }

}
