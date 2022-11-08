using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fakemon
{
    public FakemonBase Base {get; set;}
    public int Level {get; set;}

    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Fakemon(FakemonBase fBase, int fLevel) {

        Base = fBase;
        Level = fLevel;
        HP = MaxHP;

        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.level <= Level)
                Moves.Add(new Move(move.moveBase));

            if (Moves.Count >= 4)
                break;
        }
    }

    //Calcs the base stats...
    public int Attack {
        get { return Mathf.FloorToInt((Base.Attack * Level / 100f) + 5); }
    }
        public int Defense {
        get { return Mathf.FloorToInt((Base.Defense * Level / 100f) + 5); }
    }
        public int SpAttack {
        get { return Mathf.FloorToInt((Base.SpAttack * Level / 100f) + 5); }
    }
        public int SpDefence {
        get { return Mathf.FloorToInt((Base.SpDefence * Level / 100f) + 5); }
    }
        public int Speed {
        get { return Mathf.FloorToInt((Base.Speed * Level / 100f) + 5); }
    }
        public int MaxHP {
        get { return Mathf.FloorToInt((Base.MaxHP * Level / 100f) + 10); }
    }
}
