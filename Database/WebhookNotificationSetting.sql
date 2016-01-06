CREATE TABLE [dbo].[WebhookNotificationSetting]
(
	[NotificationId] INT NOT NULL PRIMARY KEY, 
    [Url] VARCHAR(100) NULL, 
    [SubscriptionId] INT NULL
)
