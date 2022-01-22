using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    public int maxOxygenLevel = 100;
    public static float currentOxygenLevel;
    public float oxygenUsedPerSecond;

    public PlayerOxygeneBar oxygenBar;
    public SubmarineMovement submarine;
    public SubmarineOxygene submarineOxygene;
    void Start()
    {
        currentOxygenLevel = maxOxygenLevel;
        oxygenBar.SetMaxOxygen(maxOxygenLevel);
    }

    void Update()
    {
        if (submarine.getPlayerInside() && submarineOxygene.GetCurrentSubOxygeneLevel() >= 0)
        {
            OxygenIncrease(oxygenUsedPerSecond);

        }
        else
        {
            OxygenDecrease(oxygenUsedPerSecond);
        }



    }

    public void OxygenDecrease(float _oxygenUsedPerSecond)
    {
        if (currentOxygenLevel > 0)
        {
            currentOxygenLevel -= _oxygenUsedPerSecond * Time.deltaTime;
            oxygenBar.SetOxygenLevel(currentOxygenLevel);
        }
    }

    public void OxygenIncrease(float _oxygenUsedPerSecond)
    {
        if (currentOxygenLevel < maxOxygenLevel)
        {
            currentOxygenLevel += _oxygenUsedPerSecond * Time.deltaTime;
            oxygenBar.SetOxygenLevel(currentOxygenLevel);
        }
    }

    public float GetPlayerOxygen()
    {
        return currentOxygenLevel;
    }



}
