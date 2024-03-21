using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private float timeLimit;
    private float time;
    [SerializeField] private GameObject targetPrefab;
    [SerializeField] private float minRadius, maxRadius,minHeight,maxHeight;
    private void Update()
    {
        time += Time.deltaTime;
        if (time < timeLimit && !GameObject.FindAnyObjectByType<Target>())
        {
            SpawnerRoutine();
        }
        else if (time > timeLimit)
        {
            //end game save score
        }
    }
    private void SpawnerRoutine()
    {
        float distance = Random.Range(minRadius,maxRadius);
        float height = Random.Range(minHeight, maxHeight);
        float angle = Random.Range(0,2*Mathf.PI);

        Vector3 direction = new Vector3(Mathf.Cos(angle),height, Mathf.Sin(angle)).normalized;
        Instantiate(targetPrefab, direction * distance, Quaternion.identity,transform);
    }
}
