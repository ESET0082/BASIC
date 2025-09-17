# DLMS/COSEM Communication Example

This C# example demonstrates how to define and pack an OBIS code and construct a GET request APDU for DLMS/COSEM communication.

The ObisCode class represents a DLMS OBIS code with six bytes.

The GetRequestApdu class builds a GET request APDU message using the OBIS code, class ID, and attribute ID.

In the example, the OBIS code for Active Energy Import (1-0:1.8.0.255) is used.

The GET request targets the Register class (class ID 3) and attribute ID 2 (value).

The generated APDU is printed in a readable hex format.
This example can be extended for full DLMS/COSEM protocol implementation.



