using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveToScene : MonoBehaviour {
    // For Unity, when you get out of scene and go to 
    // another scene, the prev scene will stop existing 
    // in memory. 
    private void start() {
        // This is good for conveying message to other parts of the game. 
        // For if you don't want to destroy the scene... 
        // gameObject is refering to the game object this script is attached to.
        DontDestroyOnLoad(gameObject);  
    }

    public void changeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame() {
        Debug.Log("You quit the game!");
        Application.Quit();
    }
} 
