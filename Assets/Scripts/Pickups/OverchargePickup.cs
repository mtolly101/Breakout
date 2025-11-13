using UnityEngine;

public class OverchargePickup : Pickup
{
    protected override void OnPickup(ActiveWeapon activeWeapon)
    {
        if (activeWeapon == null) return;
        var buffs = activeWeapon.GetComponentInParent<PlayerBuffs>();
        if (buffs != null) buffs.TriggerOvercharge();
    }
}