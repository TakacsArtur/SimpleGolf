using System;
using TMPro;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject golfBall, directionProvider, Eventsystem, UIDisplay;
    private float golfForcexOffset, golfForceyOffset, golfForcezOffset;

    public enum batType {theBigDriver, putter, medDriver}

    public batType currentBat;
    Rigidbody rb;
    public bool inPutterZone = false;
    void Start()
    {
        rb = golfBall.GetComponent<Rigidbody>();
        //basically we inform the game and the UI, what was set in the editor
        SetCurrentBat(currentBat);
    }

     void OnTriggerEnter()
    {   
        if (Input.GetButton("Fire1")){
            golfBall.GetComponent<Gofball_Location>().BallHit();
            Debug.Log("Ball was hit");
            LaunchBall(currentBat);
        } 
    }

    void LaunchBall(batType currentBat)
    {
        
        if (currentBat == batType.putter){
            golfForcexOffset = 3;
            golfForceyOffset = 0;
            golfForcezOffset = 3;
        }

        if (currentBat == batType.theBigDriver){
            golfForcexOffset = 30;
            golfForceyOffset = 10;
            golfForcezOffset = 30;

        }

        if(currentBat == batType.medDriver){
            golfForcexOffset = 15;
            golfForceyOffset = 3;
            golfForcezOffset = 15;

        }

        Debug.Log("Current heading: " + directionProvider.transform.forward);
        Debug.Log("Selected battype: " + currentBat);
        rb.AddForce(directionProvider.transform.forward.x * golfForcexOffset , directionProvider.transform.forward.y + golfForceyOffset, directionProvider.transform.forward.z * golfForcezOffset, ForceMode.Impulse);
        Eventsystem.GetComponent<ScreCounter>().ballHit();
        GetComponent<Clubrotate>().resetIgnoreInput();
    }

    public void SetCurrentBat(batType bat)
    {
        currentBat = bat;
        Debug.Log("Current bat is" + bat);
        updateDisplay(UIDisplay);
    }

    public void updateDisplay(GameObject uiDisplay){
        String nickname = "";

        if(currentBat == batType.putter) nickname = "Putter";
        if(currentBat == batType.medDriver) nickname = "Hybrid";
        if(currentBat == batType.theBigDriver) nickname = "Driver";

        uiDisplay.GetComponent<TMP_Text>().text = nickname;

    }

    public void SelectPutter(bool toRight){
        
       if(inPutterZone)
        return;
        
        var batTypeList = (batType[])Enum.GetValues(typeof(batType));
        var cnt = 0;
        var result = 0;
        foreach (var bat in batTypeList)
        {
            
            if (bat == currentBat)
                result = cnt;
            cnt++;
        }

       if(toRight)
       {
        Debug.Log("Cycling to the right");
        if (result ==0)
            result = batTypeList.Length-1;
        else 
            result -=1;
       } 

       Debug.Log(result);

       if(!toRight)
       {
        if(result == batTypeList.Length-1)
            result =0;
        else
            result+=1;
       }

        SetCurrentBat(batTypeList[result]);
    }

    public void setPutterZone(){
        inPutterZone =true;
        SetCurrentBat(batType.putter);
    }

    public void reSetInPutterZone(){
        inPutterZone =false;
    }

    public batType GetCurrentBat()
    {
        return currentBat;
    }

}
