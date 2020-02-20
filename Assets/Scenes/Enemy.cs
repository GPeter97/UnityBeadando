using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject enemyPrefab;

    float spawnolasitavolsag = 12f;
    float enemymennyisége = 5;
    float kovetkezoenemy = 1;

    void Update () {

        kovetkezoenemy -= Time.deltaTime;

        if (kovetkezoenemy <= 0)
        {
            kovetkezoenemy = enemymennyisége;
            enemymennyisége *= 0.9f;
            if (enemymennyisége < 2)
                enemymennyisége = 2;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;

            offset = offset.normalized * spawnolasitavolsag;

            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }

    }
}
