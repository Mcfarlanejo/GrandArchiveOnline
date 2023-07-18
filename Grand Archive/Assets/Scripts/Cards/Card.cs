using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { Norm, Fire, Water, Wind, Arcane, Crux, Luxem, Tera }
public enum Deck { Material, Main }
public enum Type { Action, Ally, Attack, Champion, Domain, Item, Regalia, Unique, Weapon, Null }
public enum Subtype {   Accessory, Angel, Animal, Ape, Artifact, Assassin, Bauble, Beast, Bird, Boar, Book, Bull, Castle, Cleric, Construct, Craft, Crystal, Dagger, Dog, Dryad, Elemental,
                        Fairy, Flute, Golem, Guardian, Harmony, Horn, Horse, Human, Instrument, Isle, Lion, Mage, Map, Melody, Phoenix, Rabbit, Ranger, Reaction, Ring, Scepter, Selkie, 
                        Serpent, Skill, Slime, Spell, Spirit, Squirrel, Sword, Tamer, Turtle, Warrior, Wolf, Null }
public enum Class { Assassin, Cleric, Guardian, Mage, Ranger, Tamer, Spirit, Warrior }

public enum TriggerType { OnEnter, OnAttack, OnKill, OnDeath, OnChampionHit, OnHit, OnBanish, OnCast, Static, EndOfTurn }

[System.Serializable]
public class CardEffect
{
    public bool classBonus;
    public bool elementBonus;
    public bool requiresTap;
    public TriggerType triggerType;
    public Effect effect;
}

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;

    public Sprite artwork;
    public int collectorNumber;
    public string set = "DOA";

    public Deck deck;
    public Element element;
    public Type type1;
    public Type type2 = Type.Null;
    public Subtype[] subtypes;

    public int cost;
    public int level;
    public int life;
    public int power;
    [HideInInspector] public int tempPower = 0;
    public int durability;
    public bool fast = false;
    public bool floatingMemory;
    [HideInInspector] public bool rested = false;
    public bool efficiency = false;

    public CardEffect[] effects;
}
