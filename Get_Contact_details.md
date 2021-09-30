## GET Request to fetch Contact details

### Request URl: `https://api.kylas.io/v1/contacts/<contact_id>`

`contact_id` would be the id of the contact whose details are to be fetched. It can be found from Contact details page url.

#### Sample example request: `https://api.kylas.io/v1/contacts/90010`

### Request Type: `GET`
### Headers required: `api-key: <Users_api_key>`

### Sample headers JSON below:

`{
	'Content-Type': 'application/json',
	'api-key': <Users_api_key>
}`

### Sample response:

```{
	"createdAt": "2021-09-30T07:06:50.934+0000",
	"updatedAt": "2021-09-30T07:06:50.934+0000",
	"createdBy": 830,
	"updatedBy": 830,
	"recordActions": {
		"read": true,
		"update": true,
		"delete": true,
		"email": true,
		"call": true,
		"sms": true,
		"task": true,
		"note": true,
		"meeting": true,
		"deleteAll": true
	},
	"metaData": {
		"idNameStore": {
			"country": {},
			"updatedBy": {
				"830": "Contact updated by"
			},
			"createdBy": {
				"830": "Contact created by"
			},
			"timezone": {},			
			"company": {},
			"salutation": {},
			"ownerId": {
				"830": "Contact_owner"
			}
		}
	},
	"id": 6279,
	"ownerId": 830,
	"firstName": "Contact's first name",
	"lastName": "Contact's last name",
	"dnd": true,
	"timezone": "Asia/Calcutta",
	"address": "sample address",
	"city": "Mumbai",
	"state": "Maharashtra",
	"zipcode": "400102",
	"country": "IN",
	"facebook": "https://www.fb.com",
	"twitter": "https://www.ty.com",
	"linkedin": "https://www.li.com",
	"department": "Engineering",
	"designation": "Master",
	"stakeholder": false
}