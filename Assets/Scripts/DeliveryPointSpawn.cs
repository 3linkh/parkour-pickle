using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPointSpawn : MonoBehaviour
{
    public GameObject spawnItemPrefab;
    
    public float respawnTime = 10f;

    public Transform spawner;
    public Transform [] Spawners = new Transform[5];

    QuestManager questManager;
    void Start()
    {
        questManager = GetComponent<QuestManager>();
        //StartCoroutine("DeployPowerUpWave");
        
    }

    void Update()
    {
        
        {
            
            
        }
    }

    void DeployPowerUp()
    {
        GameObject a = Instantiate(spawnItemPrefab) as GameObject;
        a.transform.position = spawner.position;
    }

    IEnumerator DeployPowerUpWave()
    {
        for(int i = 0; i < Spawners.Length; i++)

        {
            yield return new WaitForSeconds(respawnTime);
            DeployPowerUpRandomLocation();
        }
        
    }

    public void DeployPowerUpRandomLocation()
    {
        int spawnerCount = Random.Range(0,4);
        
        {
            GameObject a = Instantiate(spawnItemPrefab) as GameObject;
            a.transform.position = Spawners[spawnerCount].position;  
        }
                
    }
}
