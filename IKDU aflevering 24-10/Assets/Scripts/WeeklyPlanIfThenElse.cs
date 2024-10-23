using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanIfThenElse : MonoBehaviour
{
    string[] Weekday = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    void Start()
    {
        string Day = "";

        for (int x = 0; x <= 6; x++)
        {

            Day = Weekday[x];

            {
                if (Day == "Monday") 
                { 
                    Debug.Log("Most important activity for the day: Work 16-21"); 
                }
                else if (Day == "Tuesday") 
                { 
                    Debug.Log("Most important activity for the day: Tour to Det Elektriske Hjørne"); 
                }
                else if (Day == "Wednesday") 
                { 
                    Debug.Log("Most important activity for the day: Napping"); 
                }
                else if (Day == "Thursday") 
                { 
                    Debug.Log("Most important activity for the day: Pubcrawl"); 
                }
                else if (Day == "Friday") 
                {
                    Debug.Log("Most important activity for the day: Weekend celebration"); 
                }
                else if (Day == "Saturday") 
                {
                    Debug.Log("Most important activity for the day: Halloween Hygge"); 
                }
                else if (Day == "Sunday") 
                { 
                    Debug.Log("Most important activity for the day: Dungeons And Dragons"); 
                }

                
            }
        }
    }

}
