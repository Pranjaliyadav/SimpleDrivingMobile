using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class AndroidNotificationHandler : MonoBehaviour
{
#if UNITY_ANDROID
    private const string CHANNEL_ID = "notification_channel";
    public void ScheduleNotification(DateTime dateTime)
    {
        AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel
        {
            Id = CHANNEL_ID,
            Name = "Notification Channel",
            Description = "Some random description",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

        AndroidNotification notification = new AndroidNotification
        {
            Title = "Energy Recharged!",
            Text = "Your energy has recharged, come back to play again!",
            SmallIcon = "default", //can set your own in edit>project settings >mobile noti > android > set icons and identifier
            LargeIcon = "default", //when left default shows unity icon on noti
            FireTime = dateTime, 
        };

        AndroidNotificationCenter.SendNotification(notification, CHANNEL_ID);


    }
#endif
}
