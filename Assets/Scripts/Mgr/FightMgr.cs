using System.Data.Common;
using QZGFramework;
using UnityEngine;

public class FightMgr : SingletonMono<FightMgr>
{
    public void Damage(DamageType damageType, int damage, CharacterBase attacker, CharacterBase defender)
    {

        if (damageType == DamageType.Physical)
        {
            //物理伤害
            defender.CurrentHp -= Mathf.Max(1, damage - defender.Defense);
        }
        else if (damageType == DamageType.Magic)
        {
            //魔法伤害
            defender.CurrentHp -= Mathf.Max(1, damage - defender.MagicDefense);
        }
        else if (damageType == DamageType.Real)
        {
            //真实伤害
            defender.CurrentHp -= damage;
        }
    }
}
