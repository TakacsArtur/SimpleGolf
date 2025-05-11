using System.Collections;
using UnityEngine;

public class GolfBall_Camera : MonoBehaviour
{
    public Transform target, rotationTarget, golfClub;
    private Vector3 startPosition, secondPosition, direction;
    private bool movementVectoralculated = false;

    public float heightoffsetPutter, heightoffsetBigDriver;

    void Start(){
        startPosition = target.transform.position;
    }
    void Update()
    {        
        var bat = golfClub.GetComponent<ShootBall>().GetCurrentBat();
        transform.RotateAround(rotationTarget.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime*10);

        if(movementVectoralculated){
            float realOffset = heightoffsetPutter;
            if(bat == ShootBall.batType.putter)
                realOffset = heightoffsetPutter;
            if(bat == ShootBall.batType.theBigDriver)
                realOffset = heightoffsetBigDriver;

            transform.position = new Vector3(target.transform.position.x - direction.x, target.transform.position.y+realOffset, target.transform.position.z - direction.z);
        }
    }

   public void ActivateOffset(){
        Debug.Log("Offset activated");
        startPosition = target.transform.position;
        StartCoroutine(waitForBall());
    }

    IEnumerator waitForBall(){
        yield return new WaitForSeconds((float)0.1);
        secondPosition = target.transform.position;

        direction = secondPosition - startPosition;
        movementVectoralculated = true;
    }

    public void DeActivateOffset(){
        Debug.Log("Offset deactivated");
        movementVectoralculated = false;
    }
}
