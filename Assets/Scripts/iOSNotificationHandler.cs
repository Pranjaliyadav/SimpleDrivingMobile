using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS
using Unity.Notifications.iOS;
#endif

public class iOSNotificationHandler : MonoBehaviour
{
#if UNITY_IOS

    public void ScheduleNotification(int minutes)
    {
        iOSNotification notification = new iOSNotification
        {
            Title = "Energy Recharged!",
            Subtitle = "Your energy has been recharged",
            Body = "Your energy has been recharged, come back to play again!",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound), //alert and sound both
            CategoryIdentifier = "category_a",//in future we can do like cancel category a notif, mute category-b noti 
            ThreadIdentifier = "thread1",
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new System.TimeSpan(0,minutes,0),
                Repeats = false
            } //what triggers noti, lots of option to choose from
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }


#endif
}
