## POST Lead request to create lead with Default fields available in Kylas APP

### Request URl: `https://api.kylas.io/v1/leads/`
### Request Type: `POST`
### Headers required: `api-key: <User's_api_key>`

### Sample headers JSON below:

`{
	'Content-Type': 'application/json',
	'api-key': <User's_api_key>
}`

### Request body in json format:

```{
	"salutation": 844,
	"firstName": "Rohit",
	"lastName": "Sharma",
	"pipeline": {
		"id": 11,
		"name": "Default Lead Pipeline",
		"stage": {
			"id": 41,
			"name": "Open"
		}
	},
	"emails": [{
		"type": "OFFICE",
		"value": "rohit.sharma@gmail.com",
		"primary": true
	}],
	"phoneNumbers": [{
		"type": "MOBILE",
		"code": "IN",
		"dialCode": "+91",
		"value": "9898989898",
		"primary": true
	}],
	"timezone": "Asia/Calcutta",
	"address": "601, Sarvodaya building, Behrambagh, Jogeshwari West",
	"city": "Mumbai",
	"state": "Maharashtra",
	"zipcode": "400102",
	"companyName": "Mumbai Indians",
	"country": "IN",
	"facebook": "https://www.fb.com",
	"twitter": "https://www.ty.com",
	"linkedIn": "https://www.li.com",
	"department": "Management",
	"designation": "Manager",
	"companyIndustry": "SPORTS",
	"companyBusinessType": "partner",
	"companyEmployees": 10996,
	"companyAnnualRevenue": 10000000,
	"companyWebsite": "https://www.mi.com",
	"companyCity": "Mumbai",
	"companyState": "Maharashtra",
	"companyZipcode": "400102",
	"companyAddress": "MI Pvt ltd",
	"companyCountry": "IN",
	"requirementName": "2 bhk",
	"products": [{
		"id": 890,
		"name": "Double Bed room Apartments"
	}],
	"requirementCurrency": "INR",
	"requirementBudget": 2500000,
	"campaign": 847,
	"source": 848,
	"customFieldValues": {}
} 