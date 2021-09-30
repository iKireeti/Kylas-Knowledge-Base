## GET Request to fetch Deal details

### Request URl: `https://api.kylas.io/v1/deals/<deal_id>`

`deal_id` would be the id of the deal whose details are to be fetched. It can be found from Deal details page url.

### Request Type: `GET`
### Headers required: `api-key: <Users_api_key>`

### Sample headers JSON below:

`{
	'Content-Type': 'application/json',
	'api-key': <Users_api_key>
}`

### Sample response:

```{
	"id": 4485,
	"name": "Deal_name",
	"estimatedValue": {
		"currencyId": 431,
		"value": 300000
	},
	"actualValue": {
		"currencyId": 431,
		"value": 56788
	},
	"estimatedClosureOn": null,
	"pipeline": null,
	"forecastingType": null,
	"associatedContacts": [{
		"id": 6276,
		"name": "Associated_contact_name"
	}, {
		"id": 6277,
		"name": "Also Associated to this contact"
	}],
	"product": null,
	"company": null,
	"ownedBy": {
		"id": 830,
		"name": "Deal owner name"
	},
	"createdBy": {
		"id": 830,
		"name": "Deal created by"
	},
	"updatedBy": {
		"id": 830,
		"name": "Deal updated by"
	},
	"createdAt": "2021-09-30T05:04:37Z",
	"updatedAt": "2021-09-30T05:04:38Z",
	"actualClosureDate": null,
	"source": null,
	"campaign": null,
	"recordActions": {
		"read": true,
		"update": true,
		"note": true,
		"task": true,
		"meeting": true,
		"email": true,
		"call": true,
		"sms": true
	}
}