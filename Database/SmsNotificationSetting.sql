CREATE TABLE [dbo].[SmsNotificationSetting]
(
	[NotificationId] INT NOT NULL PRIMARY KEY, 
    [PhoneNumber] VARCHAR(13) NULL, 
    [SubscriptionId] INT NULL
)
