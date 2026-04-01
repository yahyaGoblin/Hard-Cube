using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public game_manager gameManager;
    
   void OnTriggerEnter ()
   {
        gameManager.completelevel();
   }

}
