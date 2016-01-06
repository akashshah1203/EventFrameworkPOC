CREATE TABLE [dbo].[Subscription]
(
	[SubscriptionId] INT NOT NULL PRIMARY KEY, 
    [MerchantId] INT NULL, 
    [EventTypeId] INT NULL, 
    [Description] VARCHAR(500) NULL, 
    [NotificationType] VARCHAR(50) NULL
)
