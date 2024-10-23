using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanCase : MonoBehaviour
{
    string[] Weekday = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    void Start()
    {
        for (int x = 0;x<=6;x++)
        {
            switch (Weekday[x])
            {
                case "Monday":
                    Debug.Log("Most important activity for the day: Work 16-21");
                    break;
                case "Tuesday":
                    Debug.Log("Most important activity for the day: Tour to Det Elektriske Hjørne");
                    break;
                case "Wednesday":
                    Debug.Log("Most important activity for the day: Napping");
                    break;
                case "Thursday":
                    Debug.Log("Most important activity for the day: Pubcrawl");
                    break;
                case "Friday":
                    Debug.Log("Most important activity for the day: Weekend celebration");
                    break;
                case "Saturday":
                    Debug.Log("Most important activity for the day: Halloween Hygge");
                    break;
                case "Sunday":
                    Debug.Log("Most important activity for the day: Dungeons And Dragons");
                    break;
            }
        }
    }

}
