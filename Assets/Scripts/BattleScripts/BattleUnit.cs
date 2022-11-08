using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] FakemonBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;

    public Fakemon Fakemon {get; set;}

    public void Setup()
    {
        Fakemon = new Fakemon(_base, level);
        if (isPlayerUnit)
            GetComponent<Image>().sprite = Fakemon.Base.backSprite;
        else
            GetComponent<Image>().sprite = Fakemon.Base.frontSprite;
    }
}
