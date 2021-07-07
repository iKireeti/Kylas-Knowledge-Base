var client = new RestClient("https://api.kylas.io/v1/leads/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("api-key", "<api_key>");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +
@"	""salutation"": 844," + "\n" +
@"	""firstName"": ""Rohit""," + "\n" +
@"	""lastName"": ""Sharma""," + "\n" +
@"	""pipeline"": {" + "\n" +
@"		""id"": 11," + "\n" +
@"		""name"": ""Default Lead Pipeline""," + "\n" +
@"		""stage"": {" + "\n" +
@"			""id"": 41," + "\n" +
@"			""name"": ""Open""" + "\n" +
@"		}" + "\n" +
@"	}," + "\n" +
@"	""emails"": [{" + "\n" +
@"		""type"": ""OFFICE""," + "\n" +
@"		""value"": ""rohit.sharma@gmail.com""," + "\n" +
@"		""primary"": true" + "\n" +
@"	}]," + "\n" +
@"	""phoneNumbers"": [{" + "\n" +
@"		""type"": ""MOBILE""," + "\n" +
@"		""code"": ""IN""," + "\n" +
@"		""dialCode"": ""+91""," + "\n" +
@"		""value"": ""9898989898""," + "\n" +
@"		""primary"": true" + "\n" +
@"	}]," + "\n" +
@"	""timezone"": ""Asia/Calcutta""," + "\n" +
@"	""address"": ""601, Sarvodaya building, Behrambagh, Jogeshwari West""," + "\n" +
@"	""city"": ""Mumbai""," + "\n" +
@"	""state"": ""Maharashtra""," + "\n" +
@"	""zipcode"": ""400102""," + "\n" +
@"	""companyName"": ""Mumbai Indians""," + "\n" +
@"	""country"": ""IN""," + "\n" +
@"	""facebook"": ""https://www.fb.com""," + "\n" +
@"	""twitter"": ""https://www.ty.com""," + "\n" +
@"	""linkedIn"": ""https://www.li.com""," + "\n" +
@"	""department"": ""Management""," + "\n" +
@"	""designation"": ""Manager""," + "\n" +
@"	""companyIndustry"": ""SPORTS""," + "\n" +
@"	""companyBusinessType"": ""partner""," + "\n" +
@"	""companyEmployees"": 10996," + "\n" +
@"	""companyAnnualRevenue"": 10000000," + "\n" +
@"	""companyWebsite"": ""https://www.mi.com""," + "\n" +
@"	""companyCity"": ""Mumbai""," + "\n" +
@"	""companyState"": ""Maharashtra""," + "\n" +
@"	""companyZipcode"": ""400102""," + "\n" +
@"	""companyAddress"": ""MI Pvt ltd""," + "\n" +
@"	""companyCountry"": ""IN""," + "\n" +
@"	""requirementName"": ""2 bhk""," + "\n" +
@"	""products"": [{" + "\n" +
@"		""id"": 890," + "\n" +
@"		""name"": ""Double Bed room Apartments""" + "\n" +
@"	}]," + "\n" +
@"	""requirementCurrency"": ""INR""," + "\n" +
@"	""requirementBudget"": 2500000," + "\n" +
@"	""campaign"": 847," + "\n" +
@"	""source"": 848," + "\n" +
@"	""customFieldValues"": {}" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);