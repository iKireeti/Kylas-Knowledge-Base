## Convert Lead to Contact API

### Request URl: `https://api.kylas.io/v1/leads/<lead_id>/convert`

`lead_id` would be the id of the lead which you want to convert to contact. It can be found from lead details page url.

#### Sample example request: `https://api.kylas.io/v1/leads/90010/convert`

### Request Type: `POST`
### Headers required: `api-key: <Users_api_key>`

### Sample headers JSON below:

`{
	'Content-Type': 'application/json',
	'api-key': <Users_api_key>
}`

### Request body in json format:

```{
    "contact": {
        "mode": "CREATE",
        "details": {
            "firstName": "Contact_first_name",
            "lastName": "Contact_last_name",
            "dnd": true,
            "timezone": "Asia/Calcutta",
            "address": "sample address",
            "city": "Mumbai",
            "state": "Maharashtra",
            "zipcode": "400102",
            "country": "IN",
            "facebook": "https://www.fb.com",
            "twitter": "https://www.ty.com",
            "department": "Engineering",
            "designation": "Master",
            "linkedin": "https://www.li.com"
        }
    }
}