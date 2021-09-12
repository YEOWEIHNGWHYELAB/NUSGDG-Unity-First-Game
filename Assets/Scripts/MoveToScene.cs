using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour {
    public void changeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
} 
