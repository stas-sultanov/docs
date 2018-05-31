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

L-RPC is a light-weight remote procedure call (RPC) protocol.
It is transport and format agnostic in that the concepts can be used within the same process, over sockets, over http, and utilize any format like JSON, YAML, XML. Primarily this specification defines basic data structures and the rules around their processing.

## 2 Conventions

The key words "MUST", "MUST NOT", "REQUIRED", "SHALL", "SHALL NOT", "SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in this document are to be interpreted as described in [RFC 2119](http://www.ietf.org/rfc/rfc2119.txt).

L-RPC utilizes the (Strings, Numbers, Booleans, and Null) and two structured types (Objects and Arrays).

All member names exchanged between the Client and the Server that are considered for matching of any kind SHOULD be considered to be case-sensitive. The terms function, method, and procedure can be assumed to be interchangeable.

The Client is defined as the origin of Request objects and the handler of Response objects.  
The Server is defined as the origin of Response objects and the handler of Request objects.  

## 3 Request object

A rpc call is represented by sending a Request object to a Server. The Request object has the following members:

| Field | Type | Optional | Description |
|:------|:------|:------|:------|
| method | String | false | A String containing the name of the method to be invoked. |
| params | Object | true | A Structured value that holds the parameter values to be used during the invocation of the method. |
| id | Integer | true | An identifier of invocation established by the Client The Server MUST reply with the same value in the Response object if included. This member is used to correlate the context between the two objects.|

### 3.1 Params object

If present, parameters for the rpc call MUST be provided as a Structured value. Either by-position through an Array or by-name through an Object.

*   by-position: params MUST be an Array, containing the values in the Server expected order.
*   by-name: params MUST be an Object, with member names that match the Server expected parameter names. The absence of expected names MAY result in an error being generated. The names MUST match exactly, including case, to the method's expected parameters.

## 4 Response object

When a rpc call is made, the Server MUST reply with a Response. The Response is expressed as a single Object, with the following members:

| Field | Type | Optional | Description |
|:------|:------|:------|:------|
| error | Object | true | A human-readable description of the error. This member is REQUIRED on error. This member MUST NOT exist if there was no error triggered during invocation. The value for this member MUST be an Object as defined in section 5.1.|
| id | Integer | true | An identifier of invocation established by the Client This member is REQUIRED.  It MUST be the same as the value of the id member in the Request Object.  If there was an error in detecting the id in the Request object (e.g. Parse error/Invalid Request), it MUST be Null.|
| result | Object | true | A human-readable description of the error. This member is REQUIRED on success. This member MUST NOT exist if there was an error invoking the method. The value of this member is determined by the method invoked on the Server.|

Either the result member or error member MUST be included, but both members MUST NOT be included.

### 4.1 Error object

When a rpc call encounters an error, the Response Object MUST contain the error member with a value that is a Object with the following members:

| Field | Type | Optional | Description |
|:------|:------|:------|:------|
| code | Integer | false | An error code. |
| message | String | true | A human-readable description of the error. |
| params | Array | true | An array of arguments to construct localized message. |
| traceId | String | false | A unique identifier Internal that should be used for communication with support. |

## 5 Examples

### 5.1 call with positional parameters

Request:
```yaml
method: QueryList
params:
    listName: Cars
    id: 100500
```
Response:
```yaml
error:
    code: 190
    params:
        - PatientNotes
        - Nurse
    message: 'The list {0} does not exists.'
    traceId: EJplcsCHuLu
```

---

This document and the information contained herein is provided "AS IS" and ALL WARRANTIES, EXPRESS OR IMPLIED are DISCLAIMED, INCLUDING BUT NOT LIMITED TO ANY WARRANTY THAT THE USE OF THE INFORMATION HEREIN WILL NOT INFRINGE ANY RIGHTS OR ANY IMPLIED WARRANTIES OF MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE.