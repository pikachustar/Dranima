using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fakemon
{
    FakemonBase _base;
    int level;

    public Fakemon(FakemonBase fBase, int fLevel) {

        _base = fBase;
        fLevel = level;

    }

    //Calcs the base stats...
    public int Attack {
        get { return Mathf.FloorToInt((_base.Attack * level / 100f) + 5); }
    }
        public int Defense {
        get { return Mathf.FloorToInt((_base.Defense * level / 100f) + 5); }
    }
        public int SpAttack {
        get { return Mathf.FloorToInt((_base.SpAttack * level / 100f) + 5); }
    }
        public int SpDefence {
        get { return Mathf.FloorToInt((_base.SpDefence * level / 100f) + 5); }
    }
        public int Speed {
        get { return Mathf.FloorToInt((_base.Speed * level / 100f) + 5); }
    }
        public int MaxHP {
        get { return Mathf.FloorToInt((_base.MaxHP * level / 100f) + 10); }
    }
}
