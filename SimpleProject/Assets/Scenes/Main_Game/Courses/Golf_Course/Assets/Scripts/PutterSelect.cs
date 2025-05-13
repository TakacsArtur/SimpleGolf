using System.Collections;
using UnityEngine;

public class PutterSelect : MonoBehaviour
{
    private bool isRightDirection;
    public GameObject Club;
    public void HoldTheButton(){
       
        Debug.Log("Button holding");
        StartCoroutine(WaitForABit());
    }

    IEnumerator WaitForABit(){
         
        yield return new WaitForSeconds(1);
        Club.GetComponent<ShootBall>().SelectPutter(isRightDirection);
        Debug.Log("Changed Bat");
    }

        public void setRightDirection(){
        isRightDirection = true;
    }

    public void SetLeftDirection(){
        isRightDirection = false;
    }
}
