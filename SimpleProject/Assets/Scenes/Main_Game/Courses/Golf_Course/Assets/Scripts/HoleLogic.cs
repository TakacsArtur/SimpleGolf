using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("ThankYouScene");
    }
}
