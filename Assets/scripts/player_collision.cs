using UnityEngine;

public class player_collision : MonoBehaviour
{

  public playermovement movement;

  void OnCollisionEnter (Collision collisioninfo)  
  {
    if (collisioninfo.gameObject.tag == "obstacal")
    {
      movement.enabled = false;
      FindObjectOfType<game_manager>().EndGame();
      
    }

  }

}
