using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : IUnit
{
    string _type;
    int _health;

    public Unit(string type, int health)
    {
        _type = type;
        _health = health;
    }

    public string Type => _type;
    public int Health => _health;
}
