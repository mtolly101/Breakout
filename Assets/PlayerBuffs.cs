using System.Collections;
using UnityEngine;

public class PlayerBuffs : MonoBehaviour
{
    [Header("Overcharge")]
    public bool overcharged = false;
    public float duration = 5f;
    public float damageMult = 1.5f;

    public void TriggerOvercharge()
    {
        StopAllCoroutines();
        StartCoroutine(Overcharge());
    }

    IEnumerator Overcharge()
    {
        overcharged = true;
        yield return new WaitForSeconds(duration);
        overcharged = false;
    }
}