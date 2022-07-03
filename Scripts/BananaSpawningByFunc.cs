using System;
using MathLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSpawningByFunc : MonoBehaviour
{
    private Func<double, double> _func;
    private Randomizer _rand;
    private float _mult;

    public BananaSpawningByFunc(Func<double, double> func, Randomizer randomizer, float mult)
    {
        _func = func;
        _rand = randomizer;
        _mult = mult;
    }

    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = _mult * (float)(_rand.Noize(Func((double)Time.time)));
    float lastSpawn = Time.time;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int spawnCount = (Time.time - lastSpawn) * spawnRate;
        for (int i = 0; i < spawnCount i++)
        {
            lastSpawn += spawnRate;     
            RandX = Random.Range(8.25f, 26.38f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
        spawnRate = _mult * (float)(_rand.Noize(Func((double)Time.time)));
    }
}
