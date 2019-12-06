using UnityEngine;
using UnityEngine.SceneManagement;
 
public class changeScene : MonoBehaviour
{    
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}