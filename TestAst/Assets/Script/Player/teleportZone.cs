using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportZone : MonoBehaviour
{
    void Update()
    {
        Vector3 scrPos = Camera.main.WorldToScreenPoint(transform.position);


        if (scrPos.x < 0) 
        { 
            TeleportRight(scrPos); 
        }

        if (scrPos.x > Screen.width)
        { 
            TeleportLeft(scrPos); 
        }

        if (scrPos.y < 0)
        {
            TeleportUp(scrPos);
        }

        if (scrPos.y > Screen.height) 
        {
            TeleportDown(scrPos);
        }
    }

    private void TeleportRight(Vector3 scrPos)
    {
        Vector3 goalScrPos = new Vector3(Screen.width, scrPos.y, scrPos.z);
        Vector3 targetWorldPos = Camera.main.ScreenToWorldPoint(goalScrPos);
        transform.position = targetWorldPos;
    }

    private void TeleportLeft(Vector3 scrPos) 
    {
        Vector3 goalScrPos = new Vector3(Screen.width-Screen.width, scrPos.y, scrPos.z);
        Vector3 targetWorldPos = Camera.main.ScreenToWorldPoint(goalScrPos);
        transform.position = targetWorldPos;
    }

    private void TeleportUp(Vector3 scrPos) 
    {
        Vector3 goalScrPos = new Vector3(scrPos.x, Screen.height, scrPos.z);
        Vector3 targetWorldPos = Camera.main.ScreenToWorldPoint(goalScrPos);
        transform.position = targetWorldPos;
    }

    private void TeleportDown(Vector3 scrPos)
    {
        Vector3 goalScrPos = new Vector3(scrPos.x, Screen.height-Screen.height, scrPos.z);
        Vector3 targetWorldPos = Camera.main.ScreenToWorldPoint(goalScrPos);
        transform.position = targetWorldPos;
    }
}
