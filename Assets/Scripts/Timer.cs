using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
      public Text timerText;
     private float secondsCount = 0;
     private int minuteCount = 0;
     private int hourCount = 0;
     private float tankStatus = 100;
     private float healthStatus = 100;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
     void Update(){
         UpdateTimerUI();
     }
 //call this on update
     public void UpdateTimerUI(){
         //set timer UI
         secondsCount += Time.deltaTime;
        tankStatus -= Time.deltaTime;
         timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s\nHealth:" + (int)healthStatus + "\nGas:"+(int)tankStatus;
         if(secondsCount >= 60){
             minuteCount++;
             secondsCount = 0;
         }else if(minuteCount >= 60){
             hourCount++;
             minuteCount = 0;
         }    
     }
       void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle") {
    healthStatus -= 10;
    Destroy (collision.gameObject);

     }
         if (collision.gameObject.tag == "Gas") {
    tankStatus += 10;
    if (tankStatus > 100) tankStatus = 100;
    Destroy (collision.gameObject);

     }
 
    }
}
