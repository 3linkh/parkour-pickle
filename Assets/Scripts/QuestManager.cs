using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    [SerializeField] int deliveryMoney = 50;
    [SerializeField] int failedMoney = -25;
    [SerializeField] int gameStartTime = 30;
    [SerializeField] GameObject pizza;
    [SerializeField] Timer timer;
    [SerializeField] TMP_Text questMessageText;

    public GameObject spawnItemPrefab;

    public float respawnTime = 10f;

    public Transform spawner;
    public Transform [] Spawners = new Transform[5];

    [SerializeField] float messageDelay = 2f;
    QuestManager questManager;
    
    bool itemPickedUp = false;
    bool itemDroppedOff = false;

    public bool questComplete;
    // Start is called before the first frame update
    
    void Start()
    {
        questMessageText.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.gameTime < 0 && timer.updateTime == true)
        {
            timer.updateTime = false;
            StartCoroutine(QuestFailed());
            timer.gameTime ++;
            timer.StopTimeDisplay();
            
        }
        
        else if (timer.gameTime > 0 && timer.updateTime == true)
        {
            timer.ReduceTime();
        }
    }

    public void DeliverItem()
    {
        
        itemDroppedOff = true;
        itemPickedUp = false;
                        
        pizza.SetActive(false);
        questComplete = true;
                
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Delivery Item")
        {
            DeployPowerUpRandomLocation();
            itemPickedUp = true;
            timer.gameTime = 20;
            timer.updateTime = true;

            questComplete = false;
            StartCoroutine(DeliveryQuestMessage());

        }

        if (other.gameObject.tag == "Delivery Destination" && itemPickedUp == true)
        {
            timer.updateTime = true;
            DeliverItem();
            StartCoroutine(QuestCompleted());
            Destroy(other.gameObject);
            
            
        }    
    }

    IEnumerator DeliveryQuestMessage()
    {
        questMessageText.text = "DELIVER THAT PIZZA BEFORE TIME RUNS OUT!";
        yield return new WaitForSeconds(messageDelay);
        questMessageText.text = "";
    }

    public void DeployPowerUpRandomLocation()
    {
        if (itemPickedUp == false)
        {
            int spawnerCount = Random.Range(0,4);
               
            {
                GameObject a = Instantiate(spawnItemPrefab) as GameObject;
                a.transform.position = Spawners[spawnerCount].position;
                
            }
        }
              
    }
    IEnumerator QuestCompleted()
    {
        questMessageText.text = "DELIVERY COMPLETE!";
        GetComponent<Money>().GetMoney(deliveryMoney);
        timer.gameTime = gameStartTime;
        yield return new WaitForSeconds(messageDelay);
        
        questMessageText.text = "";
        timer.updateTime = true;
    }
        
    IEnumerator QuestFailed()
    {
        questMessageText.text = "QUEST FAILED, TRY AGAIN";
        GetComponent<Money>().GetMoney(failedMoney);
        yield return new WaitForSeconds(messageDelay);
        questMessageText.text = "";
    }

    IEnumerator QuestStart()
    {
        questMessageText.text = "DELIVER THAT PIZZA BEFORE TIME RUNS OUT!";
        timer.gameTime = gameStartTime;
        yield return new WaitForSeconds(messageDelay);
        questMessageText.text = "";
    }


}
