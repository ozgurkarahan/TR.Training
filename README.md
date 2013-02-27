TR.Training
===========

The project consists of implementing an application which applies the following functions on number:  
f1: x+1
f2: x+2
f3: x+3
f4: x+4
f5: x+5

The application is divided into two parts: the client and a server which does the computations.

The client(s)
The client is a console application. It gets the X value (integer value) from the command line and requests the calculation to the server. The client displays each result as soon as it receives it. Each result must be displayed with its function name.
When all the results have been displayed, the client exits.

The Server
When the server received the client request, it launches the 5 calculation functions in parallel with the X parameters received. 
The calculation result must be sent to the client as soon each function has been evaluated (5 messages must be sent to the client) 

This server may be consumed by several instances of the client at the same time. 

