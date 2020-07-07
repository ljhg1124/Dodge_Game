using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpwn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpwn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpwn += Time.deltaTime;

        if (timeAfterSpwn >= spawnRate)
        {
            timeAfterSpwn = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // 총알이 타겟을 바라보도록 설정.
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
