Feature: PaymentNotificationInvalid
	In order to test that invalid notfications are dealt with correctly	by the Payment Notification Inbound endpoint
	When I call the endpoint with a invalid payload
	I want a status code indicating it is invalid

@notification-invalid
Scenario Outline: Invalid - Bad Request
	Given I want to go to baseURL
	When the "<Endpoint>" endpoint is called with http POST and using row "<Row>" from payload "<Payload>" 
	Then call is successful with status code "<StatusCode>"		
Examples: 
	| Endpoint                   | Payload				       | Row	| StatusCode	| 
	| PaymentNotificationInbound | InvalidAcceptUKPayload1.csv | 1		| BadRequest	| 

	

	

	


