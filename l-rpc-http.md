## HTTP Status codes

In general services must not rely on the communication protocol.
HTTP API MUST not use any HTTP status code within logic implementation.

| HTTP Code  | Description
|:---------- |:-----------
| `200` - OK | Everything went well
| `XXX`      | There was an error within the server during request processing

## Error Handling

API must return all errors in one unified format.

#### Error object
| Field   | Type    | Optional | Description
|:------- |:------- |:-------- |:------
| code    | Integer | false    | An internal error code.
| params  | Array   | true     | An array of arguments to construct localized message.
| traceId | String  | false    | A unique identifier Internal that should be used for end-to-end error traceability.

#### example
request
```yaml
method: QueryList
params:
    listName: Patients
    id: 100500
```

response
```yaml
error:
    code: 190                                 // error message code to be translated by translation engine
    params:                                   // parameters must be replaced using values from this array 
        - Cards                               // in corresponding order
    message: 'The list {0} does not exists.'  // optional body of the message on default language.
    traceId: EJplcsCHuLu
```

## Query

API must return result of any query in one unified format.

#### Query result object
| Field | Type    | Optional | Description
|:------|:--------|:---------|:-----------
| count | Integer | false    | A total number of items that matches the query.
| from  | Integer | true     | A starting index.
| to    | Integer | true     | An ending index.
| items | Array   | true     | An array of items that matches the query.

#### example
request
```yaml
method: QueryList
params:
    listName: Patients
    skip: 12
    take: 2
```

response
```yaml
result:
    count: 20
    from: 12
    to: 14
    items:
    - 
        FullName: "John Smith"
        Age: 24
    - 
        FullName: "Black Smith"
        Age: 34
```
