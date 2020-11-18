Feature: PaymentNotificationValid
	In order to test that valid notfications successfully pass through 
	the Payment Notification Inbound endpoint
	When I call the endpoint with a valid payload
	I want a status code indicating success

@notification-valid
#NOTE: these can only be run with signature validation turned off. 
Scenario Outline: Valid Accept UK
	Given I want to go to baseURL
	When the "<Endpoint>" endpoint is called with http POST and using row "<Row>" from payload "<Payload>" 
	Then call is successful with status code "<StatusCode>"	
	
Examples: 
	| Endpoint                   | Payload                   | Row  | StatusCode	|
	| PaymentNotificationInbound | ValidAcceptUKPayload1.csv | 1    | Accepted		|
	| PaymentNotificationInbound | ValidAcceptUKPayload1.csv | 2	| Accepted		|
	


@notification-valid
Scenario Outline: Valid Decline UK
	Given I want to go to baseURL
	When the "<Endpoint>" endpoint is called with http POST and using row "<Row>" from payload "<Payload>" 
	Then call is successful with status code "<StatusCode>"	
Examples: 
	| Endpoint                   | Payload						| Row	| StatusCode |
	| PaymentNotificationInbound | ValidDeclineUKPayload1.csv	| 1		| Accepted   |
	| PaymentNotificationInbound | ValidDeclineUKPayload1.csv	| 2		| Accepted   |
	

@notification-valid
Scenario Outline: Valid Accept ROI
	Given I want to go to baseURL
	When the "<Endpoint>" endpoint is called with http POST and using row "<Row>" from payload "<Payload>" 
	Then call is successful with status code "<StatusCode>"	
Examples: 
	| Endpoint                   | Payload				      | Row		| StatusCode	| 
	| PaymentNotificationInbound | ValidAcceptROIPayload1.csv | 1		| Accepted		| 
	| PaymentNotificationInbound | ValidAcceptROIPayload1.csv | 2		| Accepted		| 


@notification-valid
Scenario Outline: Valid Decline ROI
	Given I want to go to baseURL
	When the "<Endpoint>" endpoint is called with http POST and using row "<Row>" from payload "<Payload>" 
	Then call is successful with status code "<StatusCode>"	
Examples: 
	| Endpoint                   | Payload						| Row	| StatusCode | 
	| PaymentNotificationInbound | ValidDeclineROIPayload1.csv	| 1		| Accepted   | 
	| PaymentNotificationInbound | ValidDeclineROIPayload1.csv	| 2		| Accepted   | 

