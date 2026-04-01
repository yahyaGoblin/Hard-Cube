using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    bool gamehasended = false;

    public float restartdelay = 1f;

    public GameObject completelevelUI;

    public void completelevel ()
    {
     completelevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gamehasended == false)
        {
         gamehasended = true;
         Debug.Log("GAME OVER");
         Invoke("Restart", restartdelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}