using UnityEngine;

public class WaveScaler : MonoBehaviour
{
    [Header("Scene references")]
    public SpawnGate[] spawnGates;
    public Turret[] turrets;

    [Header("Scaling settings")]
    public float tickSeconds = 15f;
    public float spawnStep = 0.2f;
    public float minSpawnTime = 0.8f;
    public float turretStep = 0.1f;
    public float minTurretRate = 0.3f;

    void Start()
    {
        InvokeRepeating(nameof(ScaleOnce), tickSeconds, tickSeconds);
    }

    void ScaleOnce()
    {
        foreach (var g in spawnGates)
            g.MakeFaster(spawnStep, minSpawnTime);

        foreach (var t in turrets)
            t.MakeFaster(turretStep, minTurretRate);
    }
}