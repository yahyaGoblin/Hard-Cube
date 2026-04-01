using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;

    public Text scoretext;

    public Text highscore;

    void Start()
    {    
        updatehighscore();


    }

    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
        PlayerPrefs.SetString("highscorenumber" , scoretext.text);
        highscoreupdate();
    }


    void highscoreupdate()
    {
        if ( int.Parse(highscore.text) > int.Parse(PlayerPrefs.GetString("highscorenumber" , scoretext.text)))
        {
            PlayerPrefs.SetString("highscorenumber" , scoretext.text);
            highscore.text = scoretext.text;
        }

    }

    void updatehighscore()
    {
        highscore.text = (PlayerPrefs.GetString("highscorenumber" ));
    }

}
