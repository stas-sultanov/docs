# LITE-RPC Specification

Author: [Stas Sultanov](https://github.com/stas-sultanov)

**Table of Contents**

1.  [Overview](#overview)
2.  [Conventions](#conventions)
3.  [Request Object](#request_object)
    1.  [Params](#params)
4.  [Response Object](#response_object)
    1.  [Error Object](#error_object)
5.  [Examples](#examples)

## 1 Overview

L-RPC is a light-weight remote procedure call (**RPC**) protocol.
It is transport, state and format agnostic.
In that the concepts can be used to create state or stateful API with any protocol TCP or HTTP and utilize any format like JSON, YAML, XML.

Primarily this specification defines basic data structures and the rules around their processing.

## 2 Conventions

The key words "MUST", "MUST NOT", "REQUIRED", "SHALL", "SHALL NOT", "SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in this document are to be interpreted as described in [RFC 2119](http://www.ietf.org/rfc/rfc2119.txt).

L-RPC utilizes the (Strings, Numbers, Booleans, and Null) and two structured types (Objects and Arrays).

All member names exchanged between the Client and the Server that are considered for matching of any kind SHOULD be considered to be case-sensitive. The terms *function*, *method*, and *procedure* can be assumed to be interchangeable.

The **Client** is defined as the origin of **Request** objects and the handler of **Response** objects.  
The **Server** is defined as the origin of **Response** objects and the handler of **Request** objects.  

## 3 Request object

A RPC call is represented by sending a **Request** object to a **Server**. The **Request** object has the following members:

| Field | Type | REQUIRED | Description |
|:------|:------|:------|:------|
| method | String | true | A String containing the name of the method to be invoked. |
| params | Object | false | A Structured value that holds the parameter values to be used during the invocation of the method. |
| id | Integer | false | An identifier of invocation established by the Client.<br/>The Server MUST reply with the same value in the **Response** object if included.<br/>This member is used to correlate the context between the two objects.|

### 3.1 Params object

If present, parameters for the RPC call MUST be provided as a Structured value. Either by-position through an Array or by-name through an Object.

*   by-position: params MUST be an Array, containing the values in the Server expected order.
*   by-name: params MUST be an Object, with member names that match the Server expected parameter names. The names MUST match exactly, including case, to the method's expected parameters.

The absence of expected mandatory parameter MUST result in an error being generated. 

## 4 Response object

When a RPC call is made, the **Server** MUST reply with a **Response**. The **Response** is expressed as a single Object, with the following members:

| Field | Type | REQUIRED | Description |
|:------|:------|:------|:------|
| error | Object | true on error | An Object that contains all the information regarding the errorr ocured.<br/>This member MUST NOT exist if there was no error triggered during invocation.<br/>The value for this member MUST be an Object as defined in [section 4.1](#error_object).|
| id | Integer | false | An identifier of invocation established by the Client.<br/>It MUST be the same as the value of the id member in the **Request** Object.<br/>If there was an error in detecting the id in the Request object (e.g. Parse error/Invalid Request), it MUST be Null.|
| result | Object | true on success | A structured value that contains result of the method invoked on the Server.<br/>This member MUST NOT exist if there was an error invoking the method. |

Either the result member or error member MUST be included, but both members MUST NOT be included.

### 4.1 Error object

When a RPC call encounters an error, the **Response** Object MUST contain the error member with a value that is a Object with the following members:

| Field | Type | REQUIRED | Description |
|:------|:------|:------|:------|
| code | Integer | true | An error code. |
| message | String | false | A human-readable description of the error. |
| params | Array | false | An array of arguments to construct localized message. |
| traceId | String | true | A unique identifier of the error that MUST be used for end-to-end traceability. |

## 5 Examples

### 5.1 call with positional parameters

Request:
```yaml
method: QueryList
params: [Cars, 100501]
```
Response:
```yaml
result:
    name: Mercedes
```

### 5.2 call with name parameters

Request:
```yaml
method: QueryList
params: {listName: Cars, id: 100502}
```
Response:
```yaml
result:
    name: Renault
```

### 5.3 call with error

Request:
```yaml
method: QueryList
params:
    listName: Cards
    id: 100500
```
Response:
```yaml
error:
    code: 190
    params:
        - Cards
    message: 'The list {0} does not exists.'
    traceId: EJplcsCHuLu
```

---

This document and the information contained herein is provided "AS IS" and ALL WARRANTIES, EXPRESS OR IMPLIED are DISCLAIMED, INCLUDING BUT NOT LIMITED TO ANY WARRANTY THAT THE USE OF THE INFORMATION HEREIN WILL NOT INFRINGE ANY RIGHTS OR ANY IMPLIED WARRANTIES OF MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE.
