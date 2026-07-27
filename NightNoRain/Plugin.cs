using BepInEx;
using System;
using UnityEngine;


namespace NightNoRain
{
    [BepInPlugin("com.xeno.gorillatag.nightnorain", "NightNoRain", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Update()
        {
            for (int i = 1; i < BetterDayNightManager.instance.weatherCycle.Length; i++)
            {
                BetterDayNightManager.instance.weatherCycle[i] = BetterDayNightManager.WeatherType.None;
            }
            BetterDayNightManager.instance.SetTimeOfDay(8);
        }

    }
}
