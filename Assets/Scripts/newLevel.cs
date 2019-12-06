using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newLevel : MonoBehaviour
{
     public Text timerText;
     public string level;

  public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
  void OnCollisionEnter2D(Collision2D other)
  {  
   if (level != "win") {  DontDestroyOnLoad(timerText);
    DontDestroyOnLoad(other.gameObject);
   player.position = new Vector2(-3.5f, -1.8f);
}
 SceneManager.LoadScene(level);

  }
}
