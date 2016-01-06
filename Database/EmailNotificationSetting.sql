CREATE TABLE [dbo].[EmailNotificationSetting]
(
	[NotificationId] INT NOT NULL PRIMARY KEY, 
    [EmailAddress] VARCHAR(50) NULL, 
    [SubscriptionId] INT NULL
)
