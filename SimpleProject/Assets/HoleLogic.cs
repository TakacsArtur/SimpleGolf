using UnityEngine;

public class HoleLogic : MonoBehaviour
{
    public GameObject GolfBall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == GolfBall.name){
            Endgame();
        }
    }

    void Endgame(){
        Debug.Log("Hole won");
    }
}
