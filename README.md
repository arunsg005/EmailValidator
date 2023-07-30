#StatusRetreivalApplication
This application has only GET endpoint which will return list of statuses which has Busy or OutOfOffice.

Param Used:
email : ex.abc@example.com

Sample Request:
https://localhost:44305/api/statusCheck/Email?email=dave@example.com


Sample Response:


{"Email":"dave@example.com","Number_Of_events":20,"Events":[{"Id":"3e369c6a-eaef-4ad6-a64f-66dddafed4f4","Start":"2023-07-28T19:00:00","End":"2023-07-28 19:15:00 +0000","Status":"Busy","Subject":"Meeting C"},{"Id":"55a05287-570d-434d-bdf5-293a8a00214d","Start":"2023-07-29T22:00:00","End":"2023-07-29 22:15:00 +0000","Status":"Busy","Subject":"Meeting A"},{"Id":"4f6505a2-8b0b-43a2-a107-07329d758da3","Start":"2023-07-30T19:00:00","End":"2023-07-30 19:45:00 +0000","Status":"OutOfOffice","Subject":"Holiday"},{"Id":"91f35a17-8ca8-460b-95c7-0fb18a952fa8","Start":"2023-07-31T06:00:00","End":"2023-07-31 06:15:00 +0000","Status":"OutOfOffice","Subject":"Holiday"},{"Id":"a70e7e9d-0247-46dd-adcf-ac84ac74c1c8","Start":"2023-07-31T08:00:00","End":"2023-07-31 08:45:00 +0000","Status":"Busy","Subject":"Meeting C"},{"Id":"44296f3c-c867-41dc-bc40-bd668150acf4","Start":"2023-07-31T11:00:00","End":"2023-07-31 11:45:00 +0000","Status":"Busy","Subject":"Meeting B"},{"Id":"be816026-6504-4292-b030-0d9945d94df3","Start":"2023-08-03T17:00:00","End":"2023-08-03 17:45:00 +0000","Status":"Busy","Subject":"Meeting A"},{"Id":"545ac5ea-fb71-40a0-bc0b-7c53cf89d5cd","Start":"2023-08-04T16:00:00","End":"2023-08-04 16:45:00 +0000","Status":"Busy","Subject":"Meeting B"},{"Id":"e94a2362-4626-467a-808d-a27d34dc5657","Start":"2023-08-06T02:00:00","End":"2023-08-06 02:15:00 +0000","Status":"Busy","Subject":"Meeting C"},{"Id":"7313365d-16ec-493c-84a6-a0f1f5ebc1f7","Start":"2023-08-06T18:00:00","End":"2023-08-06 18:30:00 +0000","Status":"Busy","Subject":"Meeting B"},{"Id":"0727b5f9-6308-4729-85e5-bb91ad697c74","Start":"2023-08-07T20:00:00","End":"2023-08-07 20:45:00 +0000","Status":"Busy","Subject":"Meeting A"},{"Id":"59ec5c71-9e64-4e56-b2bd-73ae02ccc60b","Start":"2023-08-09T15:00:00","End":"2023-08-09 15:45:00 +0000","Status":"Busy","Subject":"Meeting B"}]}
