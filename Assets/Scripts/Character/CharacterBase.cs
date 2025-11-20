using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    //角色基础属性
    [Header("角色基础属性")]
    [SerializeField]
    private float hp;
    public float Hp { get { return hp; } }
    private float currentHp;
    public float CurrentHp { get { return currentHp; } set { currentHp = value; } }
    [SerializeField]
    private float attack;
    public float Attack { get { return attack; } }
    //[SerializeField]
    // private float magicAttack;
    // public float MagicAttack { get { return magicAttack; } }
    [SerializeField]
    private float defense;
    public float Defense { get { return defense; } }
    // [SerializeField]
    // private float magicDefense;
    // public float MagicDefense { get { return magicDefense; } }
    [SerializeField]
    private float speed;
    public float Speed { get { return speed; } }
    //角色阵营
    [SerializeField]
    private int camp;
    [SerializeField]
    public Grid grid;

    
    public virtual void Movement()
    {
        //移动
    }
}
